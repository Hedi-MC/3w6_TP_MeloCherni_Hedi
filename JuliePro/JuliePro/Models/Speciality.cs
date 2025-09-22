using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace JuliePro.Models
{
    public class Speciality
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(25)]
        public string Name { get; set; }

        [ValidateNever]
        public ICollection<Trainer> Trainers { get; set; }

    }
}
