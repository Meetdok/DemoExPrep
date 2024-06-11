using System;
using System.Collections.Generic;

namespace DemoExamen.Models
{
    public partial class Userrole
    {
        public Userrole()
        {
            Users = new HashSet<User>();
        }

        public int Userroleid { get; set; }
        public string Namerole { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
