using System;
using System.Collections.Generic;

namespace DemoExamen.Models
{
    public partial class User
    {
        public User()
        {
            Orderuserlists = new HashSet<Orderuserlist>();
            Userlists = new HashSet<Userlist>();
        }

        public int Userid { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? Status { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Middlename { get; set; } = null!;
        public int Userroleid { get; set; }

        public virtual Userstatus? StatusNavigation { get; set; }
        public virtual Userrole Userrole { get; set; } = null!;
        public virtual ICollection<Orderuserlist> Orderuserlists { get; set; }
        public virtual ICollection<Userlist> Userlists { get; set; }
    }
}
