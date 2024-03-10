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
    [Table("PostCategories")]
    public class PostCategory : Authditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDPostCategory { get; set; }

        [Required]
        [MaxLength(50)]
        public string NamePostCategory { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(255)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string DescriptionPost { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        public bool HomeFlag { get; set; }


        // Relationship 
        public virtual IEnumerable<Post> Posts { get; set; }

        [ForeignKey("ParentID")]
        public virtual PostCategory PostCategoryParent { get; set; }

        public virtual IEnumerable<PostCategory> ChildListPostCategory { get; set; }
    }
}
