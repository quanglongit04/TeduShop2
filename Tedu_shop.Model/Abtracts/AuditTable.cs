using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tedu_shop.Model.Abtracts
{
    public abstract class AuditTable : IAuditTable
    {
        public DateTime? CreateDate { set; get; }
        [MaxLength(256)]
        public string CreateBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        [MaxLength(256)]
        public string UpdateBy { set; get; }

        public bool Status { set; get; }

        [Maxlength(256)]
        public string MetaKeyword { set; get; }
        [Maxlength(256)]
        public string MetaDescription { set; get; }
    }
}
