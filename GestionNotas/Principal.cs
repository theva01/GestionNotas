using BLL;


namespace GestionNotas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            //abrirFormatoHija(new Principal());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void abrirFormatoHija(object FormatoHija)
        {

            if (panelPrincipal.Controls.Count > 0)
                panelPrincipal.Controls.RemoveAt(0);

            Form? formatohija = FormatoHija as Form;
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

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Estudiantes());
        }

        private void btnGrados_Click(object sender, EventArgs e)
        {
            abrirFormatoHija(new Grados());
        }
    }
}
