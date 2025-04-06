namespace Trabalho_3_Camadas
{
    public partial class CadClienteForm : Form
    {
        public CadClienteForm()
        {
            InitializeComponent();
        }

        private void CadClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (Cancelar_Click == Cancelar_Click)
            {
                CadClienteForm cadC = new CadClienteForm();
                cadC.Close();
            }
        }

        private void limpar()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbSexo.Text = "--------";
            cbStatus.Text = "--------";
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
