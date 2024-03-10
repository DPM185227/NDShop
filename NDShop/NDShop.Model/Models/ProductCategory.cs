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
    [Table("ProductCategories")]
    public class ProductCategory : Authditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProductCategory { get; set; }

        [Required]
        public string NameProductCategory { get; set; }

        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        public string DescriptionProduct { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }

        public bool HomeFlag { get; set; }


        // Product 
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
