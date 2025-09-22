using Microsoft.AspNetCore.Mvc.Rendering;

namespace JuliePro.Models.ViewModels
{
    public class TrainerVM
    {
        public Trainer Trainer { get; set; }

        public IEnumerable<SelectListItem>? SpecialitiesSelectList { get; set; }
    }
}