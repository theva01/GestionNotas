using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmEstudiante : Form
    {
        private LEstudiante estudiante;
        TextBox txtFechaNacimiento = new TextBox();
        public FrmEstudiante()
        {
            InitializeComponent();
            var listaDeTxt = new List<TextBox>();
            listaDeTxt.Add(txtNroID);   
            listaDeTxt.Add(txtNombre);   
            listaDeTxt.Add(txtApellido);   
            listaDeTxt.Add(txtCorreo);
            listaDeTxt.Add(txtFechaNacimiento);   
            listaDeTxt.Add(txtDireccion);   
            listaDeTxt.Add(txtTelefono);
            estudiante = new LEstudiante(listaDeTxt);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }
        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = dtpFechaNacimiento.Value.ToShortDateString();
        }
    }
}
