﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_AngularJS.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key, Column(Order = 0)]
        public int PostID { set; get; }
        [Key]
        [MaxLength(50)]
        [Column(TypeName ="varchar", Order = 1)]
        public string TagID { set; get; }
        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}
