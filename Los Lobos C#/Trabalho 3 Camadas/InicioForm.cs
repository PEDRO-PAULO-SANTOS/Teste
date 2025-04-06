namespace Trabalho_3_Camadas
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
        }

        private void cadastrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadClienteForm cadC = new CadClienteForm();
            cadC.Show();
        }
        private void cadastrarPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPetForm cadp = new CadPetForm();
            cadp.Show();
        }
    }
}
