using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class ShortCode
    {
        [Key]
        public int LongCodeId { get; set; }
        public string Address { get; set; }

        //public LongCode LongCode { get; set; }
    }
}
