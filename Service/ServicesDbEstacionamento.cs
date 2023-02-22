using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SolutionParking.Model;

namespace SolutionParking.Service
{
    public class ServicesDbEstacionamento
    {
        SQLiteConnection conn;
        public string StatusMessage { get; set; }
        /// <summary>
        /// Construtor que define o banco e cria a tabela Estacionamento baseada no Models
        /// </summary>
        /// <param name="dbPath"></param>
        public  ServicesDbEstacionamento(string dbPath)
        {
            if (dbPath == "") dbPath = Program.DbPath;
            conn = new SQLiteConnection(dbPath);
            conn.CreateTable<ModelEstacionamento>();
        }

        public void InserirVeiculo(ModelEstacionamento estacionamento, string vaga)
        {
            try
            {
                if (!(String.IsNullOrEmpty(estacionamento.Placa)) && 
                    (!String.IsNullOrEmpty(estacionamento.TipoVeiculo)) && 
                    (!String.IsNullOrEmpty(estacionamento.Vaga)) &&
                    (!String.IsNullOrEmpty(estacionamento.Dth_Entrada.ToString())))
                {
                    var resp = from reg in conn.Table<ModelEstacionamento>()
                               where reg.Vaga.Contains(vaga) && reg.Enable == true
                               select reg;
                    int validaVaga =  resp.Count();

                    if(validaVaga >= 1)
                    {
                        StatusMessage = String.Format("Essa vaga não pode ser preenchida");
                        MessageBox.Show($"Não é cadastrar veiculo para esta vaga");
                        
                    }
                    else
                    {
                        int result = conn.Insert(estacionamento);
                        if (result != 0)
                        {
                            StatusMessage = String.Format("{0} registro(s) adicionado(s)", result);
                        }
                        else
                        {
                            StatusMessage = String.Format("0 registro(s) adicionado(s)");
                        }
                    }                    
                }
                else
                {
                    StatusMessage = String.Format($"Não é possivel inserir esse registro. Informe os dados " +
                    "e do veiculo");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoverVeiculo(string placa)
        {
            try
            {
                if (!String.IsNullOrEmpty(placa))
                {
                    int result = conn.Table<ModelEstacionamento>().Delete(r => r.Placa == placa);
                    if (result != 0)
                    {
                        MessageBox.Show($"Veiculo retirado com sucesso");
                    }
                }
                else
                {
                    this.StatusMessage = String.Format("0 registro(s) removido(s): Informe a placa correta ");
                }
            }
            catch (Exception e)
            {
                throw new Exception(String.Format("0 registro(s) atualizado(s) {0}", e.Message));
            }
        }
        public List<ModelEstacionamento> ListarEstacionamento()
        {
            List<ModelEstacionamento> lista = new List<ModelEstacionamento>();
            try
            {
                lista = conn.Table<ModelEstacionamento>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return lista;
        }
      

    }

}


