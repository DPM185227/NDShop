using NDShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NDShop.Model.Models
{
    [Table("Products")]
    public class Product : Authditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDProduct { get; set; }

        [Required]
        public string NameProduct { get; set; }

        [Required]
        public string Alias { get; set; }

        public int IDCategory { get; set; }

        [Required]
        public string Image { get; set; } = String.Empty;

        public XElement MoreImages { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Warranty { get; set; }

        public string DescriptionProduct { get; set; } = String.Empty;

        public string Content { get; set; }

        public bool HomeFlag { get; set; }

        public bool HotFlag { get; set; }

        public int? ViewCount { get; set; }

        // Relationship
        [ForeignKey("IDCategory")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
