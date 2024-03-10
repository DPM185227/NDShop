using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int IDProduct { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string IDTag { get; set; }

        // Relationship
        [ForeignKey("IDProduct")]
        public virtual Product Product { get; set; }

        [ForeignKey("IDTag")]
        public virtual Tag Tag { get; set; }
    }
}
