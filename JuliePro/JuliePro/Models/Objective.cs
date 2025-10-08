using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace JuliePro.Models
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }


        [MinLength(4)]
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }

        [Range(1,15)]
        public double LostWeightKg { get; set; }

        [Range(1, 50)]
        public double DistanceKm { get; set; }
        
        
        public DateTime? AchievedDate {  get; set; }

        //public bool Completed { get; set;}


        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        //prop navigation
        [ValidateNever]
        public Customer Customer { get; set; }

        //public bool isComplete()
        //{
        //    if (AchievedDate == null)
        //    {

        //        Completed = false;
        //    }
        //    else { Completed = true; }
        //    return Completed;
        //}

    } 


}
