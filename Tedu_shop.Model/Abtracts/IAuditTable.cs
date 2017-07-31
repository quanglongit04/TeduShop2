using System;

namespace Tedu_shop.Model.Abtracts
{
    public interface IAuditTable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }

    }
}