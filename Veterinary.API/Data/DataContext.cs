using Microsoft.EntityFrameworkCore;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {       
        }

        //Registrar todas las entidades
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<History> Histories { get; set; }

        //Conectar con la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
