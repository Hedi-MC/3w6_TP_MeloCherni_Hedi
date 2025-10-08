using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace JuliePro.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }


        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public DateTime BirthDate { get; set; }

        [Range(100, 600)]
        public double StartWeight { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        //prop de navigation

        [ValidateNever]
        public ICollection<Objective> Objectives { get; set; }

        [ValidateNever]
        public Trainer Trainer { get; set; }

    }
}
