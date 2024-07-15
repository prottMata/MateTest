using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class Attribute
    {
        public int Id { get; set; }
        public DateTime? Deadline { get; set; }

        public virtual TableTask IdNavigation { get; set; }
    }
}
