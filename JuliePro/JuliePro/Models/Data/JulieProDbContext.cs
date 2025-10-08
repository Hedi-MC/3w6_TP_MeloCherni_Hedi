using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using JuliePro.Models;

namespace JuliePro.Models.Data
{
    public class JulieProDbContext:DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Trainer> Trainer { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Objective> Objective { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Création de champs lors de la création du model.
            base.OnModelCreating(modelBuilder);

            modelBuilder.GenerateData();
                
        }
        

    }
}
