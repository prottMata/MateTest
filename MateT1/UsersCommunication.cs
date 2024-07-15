using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class UsersCommunication
    {
        public int IdExternTask { get; set; }
        public int IdExternUser { get; set; }

        public virtual TableTask IdExternTaskNavigation { get; set; }
        public virtual UsersInfo IdExternUserNavigation { get; set; }
    }
}
