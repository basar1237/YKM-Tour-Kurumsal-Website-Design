using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Fiyat
    {
        [Key]
        public int Id { get; set; }
        public string ikon { get; set; }
        public int fiyat1 { get; set; }
        public int fiyat2 { get; set; }
        public int fiyat3 { get; set; }
        public int fiyat4 { get; set; }
        public int fiyat5 { get; set; }

        public int fiyat6 { get; set; }

    }
}