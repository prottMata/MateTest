using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class ListsTask
    {
        public int IdLists { get; set; }
        public int IdTasks { get; set; }

        public virtual TableList IdListsNavigation { get; set; }
        public virtual TableTask IdTasksNavigation { get; set; }
    }
}
