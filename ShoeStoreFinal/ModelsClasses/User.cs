using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsClasses
{
    public class User
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(Order = 1)]
        public string UserName { get; set; }
        [Column(Order = 2)]
        public string Email { get; set; }
        [Column(Order = 3)]
        public string Description { get; set; }

        public enum Role
        {
            
            User = 1,
            Admin = 2

        }
    }
}
