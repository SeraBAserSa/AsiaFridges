using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AsiaFridges.Models
{
    public class FridgeType
    {
        [Key]
        public int FridgeTypeID { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Fridge Type Name")]
        public string FridgeTypeName { get; set; }
        [Range(1, 50, ErrorMessage = "Display Order must be between 1-50")]
        public int DisplayOrder { get; set; }
    }
}
