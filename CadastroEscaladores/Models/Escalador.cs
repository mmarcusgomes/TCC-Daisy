using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEscaladores
{

    public class Escalador
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string identidade { get; set; }

        public string tipoIdentidade { get; set; }
        public string tipoSanguineo { get; set; }

        public string nome { get; set; }
        public string país { get; set; }
        public string UF { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string endereco { get; set; }
        public int? numEndereco { get; set; }
        public string CEP { get; set; }
        public string genero { get; set; }
        public string profissao { get; set; }
        public string complementoEndereco { get; set; }

        //Informações para contato
        public string telefone { get; set; }
        public string telefoneEmergencia { get; set; }
        public string nomeContatoEmergencia { get; set; }
        public string email{ get; set; }
        public string clubeAssociacao { get; set; }
    }

    public class Registro
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("escaladorIdentidade")]
        public Escalador IdentidadeEscalador { get; set; }
        public string escaladorIdentidade { get; set; }
        public TimeSpan entrada { get; set; }        
        public TimeSpan? saida { get; set; }
        public int numPulseira { get; set; }
        public int numPlacaID { get; set; }
        public decimal valor { get; set; }
        public DateTime data { get; set; }

    }

}