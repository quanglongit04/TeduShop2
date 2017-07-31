using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Model
{

    [Table("Menus")]
    public class Menu
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [required]
        public string Name { set; get; }
        [required]
        public string URL { set; get; }

        public int DisplayOrder { set; get; }
        [required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        public string Target { set; get; }
        [required]
        public bool Status { set; get; }

    }
}
