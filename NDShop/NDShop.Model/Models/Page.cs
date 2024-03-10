using NDShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("Pages")]
    public class Page : Authditable
    {
        [Key]
        public int IDPage { get; set; }

        [Required]
        [MaxLength(255)]
        public string NamePage { get; set; }

        [Column(TypeName ="varchar")]
        [MaxLength(255)]
        [Required]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}
