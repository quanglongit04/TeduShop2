using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Abtracts
{
    public interface ISeoable
    {
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
    }
}
