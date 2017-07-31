using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Abtracts
{
    public abstract class Seoable: ISeoable
    {
        [Maxlength(256)]
        public string MetaKeyword { set; get; }
        [Maxlength(256)]
        public string MetaDescription { set; get; }
        
    }
}
