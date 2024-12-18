using CatalogacaoDeMedidores.Model;
using Microsoft.EntityFrameworkCore;

namespace CatalogacaoDeMedidores.Data;

public class MedidoresContext : DbContext 
{
    // parametros que recebe como configuração
    public MedidoresContext(DbContextOptions<MedidoresContext> opts) : base(opts) //opts e uma variavel 
    {
        
    }

    public DbSet<MedidoresTria> MedidoresTria { get; set; }
    public DbSet<MedidoresVeri> medidoresVeri { get; set; }
}
