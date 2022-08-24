namespace Interfaz_sencilla_prestamo
{
    partial class Prestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPersonales = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCiudades = new System.Windows.Forms.ComboBox();
            this.comboSucursalOrigen = new System.Windows.Forms.ComboBox();
            this.DatosPrestamo = new System.Windows.Forms.Panel();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboCuota = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DatosPersonales.SuspendLayout();
            this.DatosPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco Santamar";
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.Color.Red;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmarSolicitud.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(309, 451);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(142, 74);
            this.btnConfirmarSolicitud.TabIndex = 11;
            this.btnConfirmarSolicitud.Text = "CONFIRMAR SOLICITUD";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(688, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 56);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(27, 158);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(179, 35);
            this.lblSaludo.TabIndex = 9;
            this.lblSaludo.Text = "Bienvenido, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Datos personales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Datos préstamo:";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Controls.Add(this.label5);
            this.DatosPersonales.Controls.Add(this.label4);
            this.DatosPersonales.Controls.Add(this.comboCiudades);
            this.DatosPersonales.Controls.Add(this.comboSucursalOrigen);
            this.DatosPersonales.Location = new System.Drawing.Point(27, 266);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(331, 142);
            this.DatosPersonales.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sucursal origen: ";
            // 
            // comboCiudades
            // 
            this.comboCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCiudades.FormattingEnabled = true;
            this.comboCiudades.Location = new System.Drawing.Point(131, 67);
            this.comboCiudades.Name = "comboCiudades";
            this.comboCiudades.Size = new System.Drawing.Size(183, 28);
            this.comboCiudades.TabIndex = 1;
            // 
            // comboSucursalOrigen
            // 
            this.comboSucursalOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSucursalOrigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSucursalOrigen.FormattingEnabled = true;
            this.comboSucursalOrigen.Location = new System.Drawing.Point(131, 30);
            this.comboSucursalOrigen.Name = "comboSucursalOrigen";
            this.comboSucursalOrigen.Size = new System.Drawing.Size(183, 28);
            this.comboSucursalOrigen.TabIndex = 0;
            // 
            // DatosPrestamo
            // 
            this.DatosPrestamo.Controls.Add(this.textMonto);
            this.DatosPrestamo.Controls.Add(this.label7);
            this.DatosPrestamo.Controls.Add(this.label6);
            this.DatosPrestamo.Controls.Add(this.comboCuota);
            this.DatosPrestamo.Location = new System.Drawing.Point(390, 266);
            this.DatosPrestamo.Name = "DatosPrestamo";
            this.DatosPrestamo.Size = new System.Drawing.Size(385, 142);
            this.DatosPrestamo.TabIndex = 16;
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(186, 33);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(184, 27);
            this.textMonto.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cuota:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Monto del préstamo:";
            // 
            // comboCuota
            // 
            this.comboCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCuota.FormattingEnabled = true;
            this.comboCuota.Location = new System.Drawing.Point(187, 67);
            this.comboCuota.Name = "comboCuota";
            this.comboCuota.Size = new System.Drawing.Size(183, 28);
            this.comboCuota.TabIndex = 2;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(902, 548);
            this.Controls.Add(this.DatosPrestamo);
            this.Controls.Add(this.DatosPersonales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Prestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.DatosPrestamo.ResumeLayout(false);
            this.DatosPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnConfirmarSolicitud;
        private Button btnSalir;
        private Label lblSaludo;
        private Label label2;
        private Label label3;
        private Panel DatosPersonales;
        private Label label5;
        private Label label4;
        private ComboBox comboCiudades;
        private ComboBox comboSucursalOrigen;
        private Panel DatosPrestamo;
        private Label label7;
        private Label label6;
        private ComboBox comboCuota;
        private TextBox textMonto;
        private ErrorProvider errorProvider2;
    }
}