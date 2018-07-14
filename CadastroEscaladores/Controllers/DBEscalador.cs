using CadastroEscaladores;
using System.Data.Entity;
namespace CadastroEscalador
{
    public class DBEscaladores : DbContext
    {
       
        public DBEscaladores()
            : base("name=DBEscalador")
        {
        }
       

        public virtual DbSet<Escalador> Escaladores { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }
    }



}
