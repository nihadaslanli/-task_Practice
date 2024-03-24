using Homework.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _task_Practice.Entities
{
    internal class User : IEntitiy
    {

        public int Id { get ; set ; }

        public int UserName { get; set; }
        public int Email { get; set; }
        public Role UserRole { get; set; }
        public User(int userName, int email, Role userRole)
        {
            UserName = userName;
            Email = email;
            UserRole = userRole;
        }
        public override string ToString()
        {
            return $"Id:{Id}Name:{UserName}, Email:{Email}";
        }
    }
}
