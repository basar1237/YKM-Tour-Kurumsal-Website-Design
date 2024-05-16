using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Corporate
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Baslik1 { get; set; }
        public string Aciklama1 { get; set; }
        public string Baslik2 { get; set; }
        public string Aciklama2 { get; set; }
        public string Baslik3 { get; set; }
        public string Aciklama3 { get; set; }

    }
}