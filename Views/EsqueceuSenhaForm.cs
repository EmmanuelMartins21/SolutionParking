using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionParking.Views
{
    public partial class EsqueceuSenhaForm : Form
    {
        public EsqueceuSenhaForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                Close();
            }
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            // Valida o Padrão e atualiza a nova senha

        }
    }
}
