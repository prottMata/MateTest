using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class Subtask
    {
        public int Id { get; set; }
        public int? IdTask { get; set; }
        public string SubtaskName { get; set; }
        public int IdStatus { get; set; }

        public virtual Status IdStatusNavigation { get; set; }
        public virtual TableTask IdTaskNavigation { get; set; }
    }
}
