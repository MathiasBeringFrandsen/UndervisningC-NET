using System.ComponentModel.DataAnnotations;
using Shoes.Infrastructure;

namespace Shoes.Models
{
    public class Shoe
    {
        [Display(Name = "Enter Size")]
        [Range(typeof(int), "16", "50", ErrorMessage = "Value for size must be between {1} and {2}")]
        [Required(ErrorMessage = "You forgot to enter the size")]
        [SizeCheck(ErrorMessage = "no shoes that size")]
        public int Size { get; set; }

        [Display(Name = "Enter Material")]
        [Required(ErrorMessage = "You forgot to enter material")]
        [StringLength(120, MinimumLength = 4, ErrorMessage = "Material must be at least 2 characters")]
        [ShoeValid(ErrorMessage = "Cant make shoes of lava")]
        public string Material { get; set; }

        [Display(Name = "Enter productionDate")]
        [Required(ErrorMessage = "You forgot to enter productiondate")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

    }
}