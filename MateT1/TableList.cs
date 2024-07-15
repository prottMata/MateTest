using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class TableList
    {
        public TableList()
        {
            ListsTasks = new HashSet<ListsTask>();
        }

        public int Id { get; set; }
        public string Listname { get; set; }
        public bool? DefaultList { get; set; }
        public bool? Hobby { get; set; }
        public int? UsersId { get; set; }

        public virtual UsersInfo Users { get; set; }
        public virtual ICollection<ListsTask> ListsTasks { get; set; }
    }
}
