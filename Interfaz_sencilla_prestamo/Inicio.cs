namespace Interfaz_sencilla_prestamo
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra formulario
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Este c�digo se ejecuta cuando el formulario se carga
            //El bot�n "btnSolicitar aparece inicialmente deshabilitado
            this.btnSolicitar.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //M�todo ControlBotones que recoje el texto que introduce el usuario en "txtNombre"
            ControlBotones();
        }

        private void ControlBotones()
        {
            //Recoge el texto introducido y se valida que no est� vac�o y que todas sean letras (txtNombre.Text.All(char.IsLetter)).
            if (txtNombre.Text.Trim() != String.Empty && txtNombre.Text.All(char.IsLetter))
            {
                //si es el texto introducido es v�lido entonces se habilita bot�n
                btnSolicitar.Enabled = true;
                //El mensaje de error se borra
                errorProvider1.SetError(txtNombre, "");
                btnSolicitar.Enabled = true;
            }
            else
            {
                //Si hay errores
                if (txtNombre.Text.Length == 0)
                {
                    //Se incluye un mensaje de error en errorProvider1 porque el usuario no ha introducido nada
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");
                }
                else if (!(txtNombre.Text.All(char.IsLetter)))
                {
                    //Se incluye un mensaje de error en errorProvider1 porque el usuario ha introducido n�meros y solo puede introducir
                    //letras
                    errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras");
                }
                btnSolicitar.Enabled = false;
                txtNombre.Focus();
            }
        }


        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //Cuando se crea el formulario prestamo recibe el nombre de usuario introducido
            using (Prestamo ventanaPrestamo = new Prestamo(txtNombre.Text)) 
                //con showDialog(), se crea un formulario de tipo modal(impide acceder al formulario anterior hasta que no resolvamos algo en �l-abre un mismo hilo o thread del proceso
                //para mostrar ambos por eso uno quedar� bloqueado.
            ventanaPrestamo.ShowDialog();
        }
    }
}