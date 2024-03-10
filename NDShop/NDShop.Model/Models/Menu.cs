using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDMenu { get; set; }

        [Required]
        [MaxLength(50)]
        public string NameMenu { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        public string TargetMenu { get; set; } = String.Empty;

        [Required]
        public bool StatusMenu { get; set; }

        [Required]
        public int IDGroup { get; set; }
        [ForeignKey("IDGroup")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}
