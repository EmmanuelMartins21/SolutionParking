using SolutionParking.Views;

namespace SolutionParking
{
    public partial class LoginForm : Form
    {
        private string Login { get; } = "estacionamento01";
        private string Senha { get; set; } = "parkingKta.";
        private string Padrao { get; } = "4l0Wd99?";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EntrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(LoginTextBox.Text) && !string.IsNullOrEmpty(SenhaTextBox.Text))
                {
                    if (LoginTextBox.Text == Login && SenhaTextBox.Text == Senha)
                    {
                        //Chama a tela principal
                        PrincipalForm form = new PrincipalForm();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login incorreto!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel acessar a aplicação!" + ex);
            }
        }

        private void EsqueceuSenhaBtn_Click(object sender, EventArgs e)
        {
            // Manipula os objetos na tela
            LoginTextBox.Visible = false;
            LoginTxtInsertLabel.Visible = false;
            SenhaLabel.Visible = false;
            SenhaTextBox.Visible = false;
            EntrarBtn.Visible = false;
            EsqueceuSenhaBtn.Visible = false;


            NovaSenhaLabel.Enabled = true;
            NovaSenhaTextBox.Enabled = true;
            NovaSenhaLabel.Visible = true;
            NovaSenhaTextBox.Visible = true;
            SalvarBtn.Enabled = true;
            SalvarBtn.Visible = true;
            PadraoLabel.Visible = true;
            PadraoTextBox.Visible = true;
            CancelarBtn.Visible = true;

        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NovaSenhaTextBox.Text) && !string.IsNullOrEmpty(PadraoTextBox.Text))
            {
                if (PadraoTextBox.Text == Padrao)
                {
                    //Atualiza a senha
                    Senha = SenhaTextBox.Text;

                    // Muda a propriedade Visible dos objetos 
                    LoginTextBox.Visible = true;
                    LoginTxtInsertLabel.Visible = true;
                    SenhaLabel.Visible = true;
                    SenhaTextBox.Visible = true;
                    EsqueceuSenhaBtn.Visible = true;
                    EntrarBtn.Visible = true;


                    NovaSenhaLabel.Enabled = false;
                    NovaSenhaTextBox.Enabled = false;
                    NovaSenhaLabel.Visible = false;
                    NovaSenhaTextBox.Visible = false;
                    PadraoLabel.Visible = false;
                    PadraoTextBox.Visible = false;
                    SalvarBtn.Enabled = false;
                    SalvarBtn.Visible = false;
                    CancelarBtn.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel alterar a senha!");
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}