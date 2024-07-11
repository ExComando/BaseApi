using Microsoft.EntityFrameworkCore;
namespace BaseApi.Models;
public class Conexiones : DbContext {
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
     
}