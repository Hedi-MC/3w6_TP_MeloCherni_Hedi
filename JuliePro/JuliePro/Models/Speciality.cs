using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JuliePro.Models
{
    public class Speciality
    {

        public int Id { get; set; }

        [MinLength(4)]
        [MaxLength(25)]
        public string Name { get; set; }


        
    }
}
