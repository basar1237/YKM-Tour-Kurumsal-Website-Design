using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Yatak
    {
            [Key]
            public int ID { get; set; }
            public string yatak { get; set; }
            public string wifi { get; set; }
            public string banyo { get; set; }

    }
}
