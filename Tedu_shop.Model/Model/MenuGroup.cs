using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Model
{
    [Table("MenuGroup")]

    public class MenuGroup
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [required]
        public string Name { set; get; }

        public virtual IEnumberable<Menu> Menus { set; get; }
    }
}
