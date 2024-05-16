using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Trip
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public String Ulke1 { get; set; }
        public String Aciklama1 { get; set; }
        public String FotoUrl1 { get; set; }

        public String Ulke2 { get; set; }
        public String Aciklama2 { get; set; }
        public String FotoUrl2 { get; set; }

        public String Ulke3 { get; set; }
        public String Aciklama3 { get; set; }
        public String FotoUrl3 { get; set; }

        public String Ulke4 { get; set; }
        public String Aciklama4 { get; set; }
        public String FotoUrl4 { get; set; }

        public String Ulke5 { get; set; }
        public String Aciklama5 { get; set; }
        public String FotoUrl5 { get; set; }

        public String Ulke6 { get; set; }
        public String Aciklama6 { get; set; }
        public String FotoUrl6 { get; set; }

    }
}