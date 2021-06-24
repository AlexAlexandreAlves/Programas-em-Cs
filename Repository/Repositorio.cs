using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<VeiculoPesado> VeiculosPesados { get; set; }
        public DbSet<VeiculoLeve> VeiculosLeves { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<LocacaoVeiculoPesado> LocacaoVeiculoPesados { get; set; }
        public DbSet<LocacaoVeiculoLeve> LocacaoVeiculoLeves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            
            string connUser = "bf07458e8e5095";
            string connPass = "236c2802";
            string connHost = "us-cdbr-east-04.cleardb.com";
            string connDb = "heroku_1fb931cf91c4b37";

            string connStr = $"server={connHost};Uid={connUser};Pwd={connPass};Database={connDb};SSL Mode=None";

            /*options.UseMySql(connStr, mySqlOptionsAction: mysqlOptions =>
            {
                mysqlOptions.EnableRetryOnFailure(
                maxRetryCount: 1,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null
        );
            });*/   
        }
    }
}
