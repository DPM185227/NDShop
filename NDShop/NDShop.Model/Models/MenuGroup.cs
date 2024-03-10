using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDMenuGroup { get; set; }

        [Required]
        [MaxLength(50)]
        public string NameGroup { get; set; }

        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
