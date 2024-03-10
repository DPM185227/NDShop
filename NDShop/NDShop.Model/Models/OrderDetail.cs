using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int IDOrder { get; set; }

        [Key]
        public int IDProduct { get; set; }
        public int Quanlity { get; set; }
        public int ProductPrice { get; set; }
        public int Total { get; set; }

        [ForeignKey("IDOrder")]
        public virtual Order Order { get; set; }

        [ForeignKey("IDProduct")]
        public virtual Product Product { get; set; }
    }
}
