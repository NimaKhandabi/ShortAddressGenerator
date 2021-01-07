using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LongCode
    {
        public int LongCodeID { get; set; }
        public string Address { get; set; }

        public ShortCode ShortCode { get; set; }
    }
}
