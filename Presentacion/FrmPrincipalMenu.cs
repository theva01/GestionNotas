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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        #region AbrirVentanas
        private void abrirFormatoHija(object FormatoHija)
        {

            if (panelPrincipal.Controls.Count > 0)
                panelPrincipal.Controls.RemoveAt(0);

            Form formatohija = FormatoHija as Form;
            if (formatohija != null)
            {
                formatohija.TopLevel = false;
                formatohija.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formatohija);
                panelPrincipal.Tag = formatohija;
                formatohija.Show();
                formatohija.BringToFront();
            }

        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FrmEstudiante());
        }

        private void btnGrado_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new FrmGrado());
        }
        #endregion


    }
}
