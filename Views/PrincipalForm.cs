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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void EntradaVeiculoButton1_Click(object sender, EventArgs e)
        {
            EntradaVeiculoForm form = new EntradaVeiculoForm();
            form.Show();
        }

        private void SaidaVeiculoBtn_Click(object sender, EventArgs e)
        {
            SaidaVeiculoForm form = new SaidaVeiculoForm();
            form.Show();
        }

        private void VeiculosEstacionadosButton_Click(object sender, EventArgs e)
        {
            VeiculosEstacionadosForm form = new VeiculosEstacionadosForm();
            form.Show();
        }
    }
}
