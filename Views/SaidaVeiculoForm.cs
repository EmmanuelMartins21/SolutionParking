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
    public partial class SaidaVeiculoForm : Form
    {
        public SaidaVeiculoForm()
        {
            InitializeComponent();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PlacaVeiculoTextBox.Text))
            {
                PlacaRetornoLabel.Visible = true;
                PlacaRetornoTextBox.Visible = true;
                TipoVeiculoLabel.Visible = true;
                TVeiculoRetornoTextBox.Visible = true;

                PlacaRetornoTextBox.Text = PlacaVeiculoTextBox.Text;
            }
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
