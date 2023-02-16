using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionParking.Views;

namespace SolutionParking.Views
{
    public partial class EntradaVeiculoForm : Form
    {
        public EntradaVeiculoForm()
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
    }
}
