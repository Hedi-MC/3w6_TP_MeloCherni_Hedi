namespace JuliePro.Models
{
    public class BaseDonnees
    {
        public Guid idInstance {  get; set; }

        public List<Speciality> specialities { get; set; }
        public List<Trainer> trainers { get; set; }

        public BaseDonnees() 
        {
            idInstance = Guid.NewGuid();

            specialities = new List<Speciality>();
            trainers = new List<Trainer>();
        }
    }
}
