using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Entity
{
    public class DataItem:EntityBase
    {
        public string ItemCode { get; set; }
        public string CategroyCode { get; set; }
        public string Content { get; set; }

    }
}
