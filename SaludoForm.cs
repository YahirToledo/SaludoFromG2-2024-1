using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoFromG2_2024_1
{
    internal partial class SaludoForm
    {
        public SaludoForm()
        {
            InitializeComponent();
        }

        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            MessageBox.Show("Hola " + nombre);
        }
    }
}
