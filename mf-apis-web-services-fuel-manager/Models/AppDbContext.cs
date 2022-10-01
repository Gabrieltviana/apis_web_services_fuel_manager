using Microsoft.EntityFrameworkCore;

namespace mf_apis_web_services_fuel_manager.Models
{
    public class AppDbContext : DbContext
    {
        //AppDbContext recebendo a injeção de dependencia do DbContext options
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }   
        //Tabelas no BD
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
