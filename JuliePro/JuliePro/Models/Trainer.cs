using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JuliePro.Models
{
    public class Trainer
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


        [MaxLength(50)]
        public string Photo { get; set; }



        [ForeignKey("Speciality")]
        public int SpecialityId { get; set; }

        //Propriété de Navigation

        [ValidateNever]
        public Speciality Speciality { get; set; }


    }
}