using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionParking.Model;
using SQLite;
namespace SolutionParking.Views
{
    public partial class VeiculosEstacionadosForm : Form
    {
        public VeiculosEstacionadosForm()
        {
            InitializeComponent();
        }

        private void VeiculosEstacionados_Load(object sender, EventArgs e)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Dock = DockStyle.Fill;

            ModelEstacionamento veiculoEstacionado = new ModelEstacionamento();
            dataGridView.Columns.Add("Placa", "Placa");
            dataGridView.Columns.Add("TipoVeiculo", "TipoVeiculo");
            dataGridView.Columns.Add("Dth_Entrada", "Dth_Entrada");
            dataGridView.Columns.Add("Dth_Saida", "Dth_Saida");
            dataGridView.Columns.Add("Enable", "Enable");
            dataGridView.Columns.Add("Vaga", "Vaga");

            //dataGridView.Rows.Add(veiculoEstacionado);
            dataGridView.Rows.Add(veiculoEstacionado.Placa, veiculoEstacionado.TipoVeiculo, veiculoEstacionado.Dth_Entrada, veiculoEstacionado.Dth_Saida, veiculoEstacionado.Enable, veiculoEstacionado.Vaga);
        }
        private void modelEstacionamentoBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {         
            DGV.Dock = DockStyle.Fill;

            ModelEstacionamento veiculoEstacionado = new ModelEstacionamento();
            DGV.Columns.Add("Placa", "Placa");
            DGV.Columns.Add("TipoVeiculo", "TipoVeiculo");
            DGV.Columns.Add("Dth_Entrada", "Dth_Entrada");
            DGV.Columns.Add("Dth_Saida", "Dth_Saida");
            DGV.Columns.Add("Enable", "Enable");
            DGV.Columns.Add("Vaga", "Vaga");

            DGV.Rows.Add(veiculoEstacionado);
           // DGV.Rows.Add(veiculoEstacionado.Placa, veiculoEstacionado.TipoVeiculo, veiculoEstacionado.Dth_Entrada, veiculoEstacionado.Dth_Saida, veiculoEstacionado.Enable, veiculoEstacionado.Vaga);
        }
        private void CarregaDados()
        {
            
            DataSet data = new DataSet();

            //da.Fill(data);

                        
        }

        
    }
}
