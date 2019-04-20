using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.DataItemInfo.Dto
{
    public class DataItemQueryDto
    {
        public string ItemCode { get; set; }
        public string CategroyCode { get; set; }
        public string Content { get; set; }

        public string Key { get; set; }
    }
}
