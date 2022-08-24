namespace Interfaz_sencilla_prestamo
{
    public partial class Prestamo : Form
    {
        string nombreCliente;
        string[] sucursalesOrigen;
        //String[] sucursalOrigen = {"Madrid", "Córdoba", "Valencia", "Barcelona", "Sevilla", "Málaga"};
        string[] sucursalActual = { "Madrid", "Córdoba", "Valencia", "Barcelona", "Sevilla", "Málaga", "Almería", "Cáceres", "Badajoz", "Canarias" };
        int[] cuotasDisponibles = { 12, 24, 36, 60, 120, 180, 240 };

        //Creación de dictionario; key->int y value-> double, que contiene la cantidad de cuotas como clave de tipo int, y como valor 
        //el monto del interés de tipo double
        Dictionary<int, double> interesesBase ;

        //Constructor Prestamo que recibe el nombre de usuario
        public Prestamo(String nombre)
        {
            InitializeComponent();
            //Se inicializa la variable nombre con el dato recibido como parámetro en el constructor
            nombreCliente = nombre;

            //En un archivo .txt tenemos las sucursales de origen que serán cargadas en el array sucursal origen
            //Este archivo se encuentra en Recursos/files
            string listadoSucursalesOrigen = "";
            listadoSucursalesOrigen = Properties.Resources.sucursalesOrigen.ToString();

            //internamente en el fichero de texto las líneas están separadas así "\r\n", 
            //se genera un nuevo array en el que el cual el separador sea el string indicado.
            //StringSplitOptions.RemoveEmptyEntries , con esta opción indicamos que si hay alguna línea vacía la elimine.
            //No habrá string vacíos dentro del array


            sucursalesOrigen = listadoSucursalesOrigen.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //Cada cuota tiene asignado un interés.
            //Se inicializa el diccionario que contiene la cuota y el interés correspondiente.

            interesesBase = new Dictionary<int, double>();
            int i;
            double intereses;

            for (i = 0, intereses = 3.0; i < cuotasDisponibles.Length; i++, intereses += 0.5)
            {
                interesesBase[cuotasDisponibles[i]] = intereses; //12 ->3.0   24 ->3.5  36 ->4 así sucesivamente..
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //Evento Prestamo_Load que se ejecuta cuando se carga el formulario
        private void Prestamo_Load(object sender, EventArgs e)
        {
            popularCuotas();
            popularLugares();
            popularSucursalesActuales();
            //se concatena el texto inicial con el recogido por parámetro.
            lblSaludo.Text += nombreCliente;
        }

        void popularCuotas()
        {
            for (int i = 0; i < cuotasDisponibles.Length; i++)
            {
               //se añade cada elemento del array al combo de cuotas en el formulario de diseño
                comboCuota.Items.Add(cuotasDisponibles[i]);

            }
        }
        void popularLugares()
        {
            for (int i = 0; i < sucursalesOrigen.Length; i++)
            {
                comboSucursalOrigen.Items.Add(sucursalesOrigen[i]);
            }
        }
        void popularSucursalesActuales()
        {
            for (int i = 0; i < sucursalActual.Length; i++)
            {
                comboCiudades.Items.Add(sucursalActual[i]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        double calcularIntereses()
        {
            string sucursalOrigenSeleccionada = comboSucursalOrigen.SelectedItem.ToString().ToLower();
            string sucursalCiudadActualSeleccionada = comboCiudades.SelectedItem.ToString().ToLower();
            int cuotaSeleccionada = (int)comboCuota.SelectedItem;
            double intereses = interesesBase[cuotaSeleccionada];

            if (new[] { "Madrid", "Barcelona" }.Contains(sucursalOrigenSeleccionada)){
                //si la sucursal origen es Madrid o Barcelona el interes se incrementa en 0.3
                intereses += 0.3;
            }
            if (new[] { "Córdoba", "Sevilla"}.Contains(sucursalCiudadActualSeleccionada)){
                //si la sucursal origen es Córdoba o } el interes se decrementa en 0.3
                intereses -= 0.3;
            }
            return intereses;
        }

        int validaciones()
        {
            if (comboSucursalOrigen.SelectedIndex <= -1 || comboCiudades.SelectedIndex <= -1)
            {
                return 1; //retorna 1 cuando no se han seleccionado sucursales origen y actual
            }
            else
            {
                if (!textMonto.Text.All(char.IsDigit) || (textMonto.Text == "") || (comboCuota.SelectedIndex <= -1))
                {
                    return 2; //no se introdujo el monto, o el monto no es numérico o no se ha 
                }
                else
                {
                    return 0;//datos correctos
                }
            }
           
        }

        private void btnConfirmarSolicitud_Click(object sender, EventArgs e)
        {
            int resultadoValidarCampos = validaciones();
            switch (resultadoValidarCampos)
            {
                case 0:
                    {//todo correcto
                        errorProvider2.SetError(DatosPersonales, "");//Borramos errores
                        errorProvider2.SetError(DatosPrestamo, "");
                        double interesMensual = calcularIntereses();//calculamos intereses
                        double montoSolicitado = double.Parse(textMonto.Text);//Se recoge el dato del formulario y se convierte a double
                        int cuotasSeleccionadas = (int)comboCuota.SelectedItem;//Se recogen las cuotas del formulario y se convierte a int
                        double interesesAplicar = montoSolicitado * (interesMensual / 100) * cuotasSeleccionadas;//Calculamos el interes a aplicar
                        double montoAPagar = montoSolicitado + interesesAplicar; //se obtiene el monto final a pager por el préstamo

                        //Se configura mensaje para mostrar al usuario
                        string mensaje = "Su préstamo por " + montoSolicitado + " en " + cuotasSeleccionadas + 
                            " cuotas se concederán con un interes del " + interesMensual + " % mensual.\nEl monto final asciende a " + montoAPagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "Cálculo de intereses", buttons);
                    }
                    break;
                case 1:
                    {
                        errorProvider2.SetError(DatosPersonales, "Debe completar todos los datos personales");
                        errorProvider2.SetError(DatosPrestamo, "");
                    }
                    break;
                case 2:
                    {
                        errorProvider2.SetError(DatosPrestamo, "Debe completar los datos del préstamo");
                        errorProvider2.SetError(DatosPersonales, "");
                    }
                    break;

            }
        }
    }
}
