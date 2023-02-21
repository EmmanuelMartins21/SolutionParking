using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SolutionParking.Model
{
    [Table("Estacionamento")]
    public class ModelEstacionamento
    {

        [NotNull]
        public String Placa { get; set; }
        [NotNull]
        public String TipoVeiculo { get; set; }
        [NotNull]
        public DateTime Dth_Entrada { get; set; }
        
        public DateTime  Dth_Saida { get; set; }
        [NotNull]
        public Boolean Enable { get; set; }
        [NotNull]
        public String Vaga { get; set; }


        public ModelEstacionamento()
        {
            this.Placa = "";
            this.TipoVeiculo = "";
            this.Enable = true;
            //this.Dth_Entrada = DateTimePicker;

        }
    }
    
}
