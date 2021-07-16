using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key, Column(Order = 0)]
        public int ProductID { set; get; }
        [Key]
        [Column(TypeName ="varchar",Order =1)]
        [MaxLength(50)]
        public string TagID { set; get; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}
