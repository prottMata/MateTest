using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class TableTask
    {
        public TableTask()
        {
            ListsTasks = new HashSet<ListsTask>();
            Subtasks = new HashSet<Subtask>();
            UsersCommunications = new HashSet<UsersCommunication>();
            IdStatus = 1;
        }

        public int Id { get; set; }
        public string Taskname { get; set; }
        public int? IdStatus { get; set; }

        public virtual Status IdStatusNavigation { get; set; }
        public virtual Attribute Attribute { get; set; }
        public virtual ICollection<ListsTask> ListsTasks { get; set; }
        public virtual ICollection<Subtask> Subtasks { get; set; }
        public virtual ICollection<UsersCommunication> UsersCommunications { get; set; }
    }
}
