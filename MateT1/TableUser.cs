using System;
using System.Collections.Generic;

#nullable disable

namespace MateTest2.MateT1
{
    public partial class TableUser
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime LastDate { get; set; }
        public string SchemaName { get; set; }
    }
}
