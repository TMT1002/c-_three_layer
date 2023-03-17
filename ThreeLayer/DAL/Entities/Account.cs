using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Account
    {
        public int id {  get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
    }
}
