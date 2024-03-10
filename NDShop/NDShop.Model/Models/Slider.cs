using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("Sliders")]
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDSlide { get; set; }

        [Required]
        [MaxLength(255)]
        public string NameSlide { get; set; }

        [MaxLength(500)]
        public string DescriptionSlide { get; set; } = String.Empty;

        [MaxLength(255)]
        public string Image { get; set; }

        [MaxLength(255)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public bool Status { get; set; }
    }
}
