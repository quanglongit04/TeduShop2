using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Abtracts
{
    public abstract class Switchable: ISwitchable
    {
        public bool Status { set; get; }
    }
}
