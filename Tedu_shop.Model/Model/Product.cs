using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tedu_shop.Model.Abtracts;


namespace Tedu_shop.Model.Model
{
    [Table("Products")]
    public class Product:AuditTable
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [required]
        public string Name { set; get; }

        [required]
        public string alias { set; get; }
        public string CategoryID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }      
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual Product_Category Product_Category { set; get; }

    }
}
