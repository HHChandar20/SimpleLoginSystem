using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginSystem.DAL.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Account()
        {
            Id = 0;
            Name = "NotDefined";
            Username = "NotDefined";
            Password = "NotDefined";
            Email = "NotDefined";
        }

        public override string ToString()
        {
            return Id + "," + Name + "," + Username + "," + Password + "," + Email;
        }
    }
}
