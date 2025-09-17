using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace JuliePro.Models.Data
{
    public class JulieProDbContext:DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        public DbSet<Speciality> Specialities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Création de champs lors de la création du model.
            base.OnModelCreating(modelBuilder);

            modelBuilder.GenerateData();
                
        }

    }
}
