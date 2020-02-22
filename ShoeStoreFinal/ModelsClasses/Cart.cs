using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsClasses
{
   public class Cart
    {
        [Key]
        [Column(Order = 0)]
        public int Recordid { get; set; }
        [Column(Order = 1)]
        public int CartId { get; set; }
        [Column(Order = 2)]
        public int ProductId { get; set; }
        [Column(Order = 3)]
        [DisplayName("Quantity")]
        public int Count { get; set; }
        [Column(Order = 4)]
        public System.DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
