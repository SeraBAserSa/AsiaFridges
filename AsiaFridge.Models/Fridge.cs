using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsiaFridges.Models
{
    public class Fridge
    {
        [Key]
        public int FridgeID { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Fridge Model")]
        public string FridgeModel { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Fridge Description")]
        public string FridgeDescription { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Capacity must be between 1 and 1000 liters.")]
        [DisplayName("Fridge Capacity (L)")]
        public int FridgeCapacity { get; set; }


        [Required]
        [DisplayName("Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public double Price { get; set; }

        [Required]
        [DisplayName("Fridge Status")]
        public string FridgeStatus { get; set; }
    }
}
