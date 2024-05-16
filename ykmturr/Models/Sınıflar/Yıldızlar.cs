using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Yıldızlar
    {
        [Key]
        public int ID { get; set; }
        public string yıldızlar { get; set; }
    }
}