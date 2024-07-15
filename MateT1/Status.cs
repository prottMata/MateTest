using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class Status
    {
        public Status()
        {
            Subtasks = new HashSet<Subtask>();
            Tasks = new HashSet<TableTask>();
        }

        public int Id { get; set; }
        public string Statusname { get; set; }

        public virtual ICollection<Subtask> Subtasks { get; set; }
        public virtual ICollection<TableTask> Tasks { get; set; }
    }
}
