using System;
using System.Collections.Generic;

namespace DemoExamen.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Userlists = new HashSet<Userlist>();
        }

        public int Shiftid { get; set; }
        public DateTime Datestart { get; set; }
        public DateTime Dateend { get; set; }

        public virtual ICollection<Userlist> Userlists { get; set; }
    }
}
