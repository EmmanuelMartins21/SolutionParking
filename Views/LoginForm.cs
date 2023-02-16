using SolutionParking.Views;

namespace SolutionParking
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EntrarBtn_Click(object sender, EventArgs e)
        {
            // futuramente haverá um metodo para validar o Login com o Banco de dados
            if(!string.IsNullOrEmpty(LoginTextBox.Text) && !string.IsNullOrEmpty(SenhaTextBox.Text))
            {
                //Chama a tela principal
                PrincipalForm form = new PrincipalForm();
                form.Show();
            }            
        }

        private void EsqueceuSenhaBtn_Click(object sender, EventArgs e)
        {
            EsqueceuSenhaForm form = new EsqueceuSenhaForm();
            form.Show();
        }

        private bool ValidaLogin(string login, string senha)
        {
            return false;
        }

    }
}