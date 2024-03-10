using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Abstract
{
    public abstract class Authditable : IAuthditable
    {
        // Authditable
        public DateTime? CreateAt { get; set; }

        [MaxLength(255)]
        public string CreateBy { get; set; }
        
        public DateTime? UpdateAt { get; set; }
        
        [MaxLength(255)]
        public string UpdateBy { get; set; }

        // SEO
        [MaxLength(255)]
        public string MetaKeyword { get; set; }
        
        [MaxLength(255)]
        public string MetaDescription { get; set; }

        //Switchable 
        public bool Status { get; set; }
        
        
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
