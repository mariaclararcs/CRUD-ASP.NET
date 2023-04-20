using Microsoft.EntityFrameworkCore;

namespace Crud.Models{
    public class DataBase : DbContext {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer(connectionString : @"Server=(localdb)\mssqllocaldb;Database=Crud;Integrated Security=True" );
        }
    }
}
