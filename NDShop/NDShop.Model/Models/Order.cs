using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDOrder { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(11)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(255)]
        public string CustomerMessage { get; set; }

        [MaxLength(255)]
        public string PaymentMethod { get; set; }
        public DateTime? CreateAt { get; set; }
        public string CreateBy { get; set; }
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }

        // relationship
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
