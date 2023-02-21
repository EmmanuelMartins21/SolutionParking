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
using SolutionParking.Model;
using SolutionParking.Service;
namespace SolutionParking.Views
{
    public partial class EntradaVeiculoForm : Form
    {
        public EntradaVeiculoForm()
        {
            InitializeComponent();
        }
        public EntradaVeiculoForm( ModelEstacionamento veiculo)
        {
            InitializeComponent();
            PlacaVeiculoTextBox.Text = veiculo.Placa;
            TipoVeiculoComboBox.Text = veiculo.TipoVeiculo;
            VagaTextBox.Text = veiculo.Vaga;
            veiculo.Enable = true;
        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja cancelar a operação?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retorno == DialogResult.Yes)
            {
                Close();
            }
        }

        private void EntradaVeiculoForm_Load(object sender, EventArgs e)
        {

        }

        private void EntradaVeiculoButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(PlacaVeiculoTextBox.Text) &&
                !(string.IsNullOrEmpty(TipoVeiculoComboBox.Text)) &&
                !(string.IsNullOrEmpty(VagaTextBox.Text))))
            {
                try
                {
                    ModelEstacionamento veiculo = new ModelEstacionamento();
                    veiculo.Placa = PlacaVeiculoTextBox.Text;
                    veiculo.TipoVeiculo = TipoVeiculoComboBox.Text;
                    veiculo.Vaga = VagaTextBox.Text;
                    veiculo.Dth_Entrada = EntradaDateTimePicker.Value;
                    veiculo.Enable = true;

                    ServicesDbEstacionamento dbEstacionamento = new ServicesDbEstacionamento(Program.DbPath);

                    dbEstacionamento.InserirVeiculo(veiculo);

                    EntradaVeiculoForm form = new EntradaVeiculoForm();
                    form.Show();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Não foi cadastrar veiculo" + ex);
                }

            }
            else
            {

            }
            
        }
    }
}
