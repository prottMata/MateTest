using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class UsersInfo
    {
        public UsersInfo()
        {
            Lists = new HashSet<TableList>();
            UsersCommunications = new HashSet<UsersCommunication>();
        }

        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public DateTimeOffset DateReg { get; set; }
        public DateTimeOffset DateLast { get; set; }

        public virtual ICollection<TableList> Lists { get; set; }
        public virtual ICollection<UsersCommunication> UsersCommunications { get; set; }
    }
}
