using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedu_shop.Model.Abtracts;

namespace Tedu_shop.Model.Model
{
    [Table("Product_Categories")]
    public class Product_Category : AuditTable
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [required]
        public string Name { set; get; }
        [required]
        public string Alias { set; get; }
        public string Decription{ set; get; }
        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumberable<Product> Products { set; get; }
    }
}
