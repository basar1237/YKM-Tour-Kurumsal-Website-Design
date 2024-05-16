using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ykmturr.Models.Sınıflar
{
    public class Main
    {
        [Key]
        public int ID { get; set; }
        public string Pofil { get; set; }
        public string Isim { get; set; }
        public string Unvan { get; set; }
        public string Acıklama { get; set; }
        public string İletisim { get; set; }
    }
}