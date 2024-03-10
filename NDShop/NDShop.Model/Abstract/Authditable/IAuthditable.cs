using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDShop.Model.Abstract
{
    // khai báo các Column table dùng chung cho nhiều bảng
    public interface IAuthditable
    {
        // Authditable
        DateTime CreatedDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        // SEO 
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        // Switchable
        bool Status { get; set; }
    }
}
