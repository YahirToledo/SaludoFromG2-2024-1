﻿using System;
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
        private int contador;

        public void InitializeComponent()
        {
            // Redimensionando y configurando la ventana
            this.Size = new Size(600,400);
            this.Text = "Form Saludo";

            //Label: Ingresa tu nombre
            lbNombre = new Label(); //Instaciamos objeto
            lbNombre.Text = "Ingresa tu nombre " + contador;
            lbNombre.Location = new Point(150, 100);

            //TextBox
            txtbNombre = new TextBox();
            txtbNombre.Text = "";
            txtbNombre.Size = new Size(250, 10);
            txtbNombre.Location = new Point(150, 130);

            //btbAceptar
            btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(150, 200);
            btnAceptar.Click += new EventHandler(btnAceptar_Click);

            //btnLimpiar 
            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(300, 200);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
           

            this.Controls.Add(lbNombre);
            this.Controls.Add(txtbNombre);
			this.Controls.Add(btnAceptar);
			this.Controls.Add(btnLimpiar);
		}
    }
}
