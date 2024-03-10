using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int IDPost { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string IDTag { get; set; }

        // Relationship
        [ForeignKey("IDPost")]
        public virtual Post Post { get; set; }

        [ForeignKey("IDTag")]
        public virtual Tag Tag { get; set; }
    }
}
