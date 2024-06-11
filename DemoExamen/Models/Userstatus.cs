using System;
using System.Collections.Generic;

namespace DemoExamen.Models
{
    public partial class Userstatus
    {
        public Userstatus()
        {
            Users = new HashSet<User>();
        }

        public int Userstatusid { get; set; }
        public string? Statustitle { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
