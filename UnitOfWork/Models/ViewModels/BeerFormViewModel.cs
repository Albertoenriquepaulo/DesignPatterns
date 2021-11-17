using System;
using System.ComponentModel.DataAnnotations;

namespace UnitOfWork.Models.ViewModels
{
    public class BeerFormViewModel
    {
        [Required]
        [Display(Name = "Beer name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Beer style")]
        public string Style { get; set; }
        public Guid? BrandId { get; set; }
        [Display(Name = "New brand name")]
        public string NewBrandName { get; set; }
    }
}
