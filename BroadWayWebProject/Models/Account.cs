using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BroadWayWebProject.Models
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        public string UserFullName { get; set; }
        public string UserName { get;set;}
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Active { get; set; }
    }

    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}