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
    public partial class FrmGrado : Form
    {
        private BllGrado grado;
        public FrmGrado()
        {
            InitializeComponent();
            cmbGrado.Text = "SELECCIONE";
            cmbGrupo.Text = "SELECCIONE";
            var listaDeCmb = new List<ComboBox>();
            listaDeCmb.Add(cmbGrado);
            listaDeCmb.Add(cmbGrupo);
            grado = new BllGrado(listaDeCmb);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grado.Registrar();
        }
    }
}
