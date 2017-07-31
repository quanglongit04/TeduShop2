using System.ComponentModel.DataAnnotations.Schema;

namespace Tedu_shop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }

        [required]
        public string Content { set; get; }
    }
}