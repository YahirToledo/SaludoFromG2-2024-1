using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaludoFromG2_2024_1
{
    internal partial class SaludoForm:Form
    {
        private Label lbNombre;
        private TextBox txtbNombre;
        private Button btnAceptar;
        private Button btnLimpiar;

        public void InitializeComponent()
        {
            // Redimensionando y configurando la ventana
            this.Size = new Size(600,400);
            this.Text = "Form Saludo";

            //Label: Ingresa tu nombre
            lbNombre = new Label(); //Instaciamos objeto
            lbNombre.Text = "Ingresa tu nombre";
            lbNombre.Location = new Point(200, 100);

            //TextBox
            txtbNombre = new TextBox();
            txtbNombre.Text = "";
            txtbNombre.Size = new Size(250, 10);
            txtbNombre.Location = new Point(200, 130);

            //btbAceptar
            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(200, 200);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);

            //btnLimpiar 
            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(400, 200);

            this.Controls.Add(lbNombre);
            this.Controls.Add(txtbNombre);
			this.Controls.Add(btnAceptar);
			this.Controls.Add(btnLimpiar);
		}
    }
}
