using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PurchaSaler.Models
{
    public class Users
    {
        [Key]
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }


    }
}
