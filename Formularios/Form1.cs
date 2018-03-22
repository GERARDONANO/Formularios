using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GuardarAlumno(object sender, EventArgs e)

        {
            if (txtRut.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || cbxciudad.Text == "")
            {

                groupBox1.Visible = false;
                const string message =
         "por favor, rellene todo el formulario";
                const string caption = "AVISO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);

            }
            else {
                groupBox1.Visible = true;
                lblRut.Text = txtRut.Text;
                lblNombre.Text = txtNombre.Text;
                lblApellido.Text = txtApellido.Text;
                lblDireccion.Text = txtDireccion.Text;
                lblCiudad.Text = cbxciudad.Text;
            }
              
        }


        private void LimpiarAlumno(object sender, EventArgs e)
        {
            
            if (txtRut.Text == "" & txtNombre.Text == "" & txtApellido.Text == "" & txtDireccion.Text == "" & cbxciudad.Text == "")
            {
                const string message =
                "No hay datos para borrar";
                const string caption = "AVISO";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
            }
            else
            {
                Limpiartextos();
                groupBox1.Visible = false;
            }

         
        }
        
        
        void Limpiartextos()
        {
            txtRut.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            cbxciudad.Text = "";
        }
    }
}
