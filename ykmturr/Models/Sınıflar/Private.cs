using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ykmturr.Models.Sınıflar
{
    public class Private
    {
        [Key]

        public int Id { get; set; }
        public string TurBaslik1 { get; set; }
        public String turFotoUrl1 { get; set; }
        
        public string TurBaslik2 { get; set; }
        public String turFotoUrl2 { get; set; }

        public string TurBaslik3 { get; set; }
        public String turFotoUrl3 { get; set; }

        public string FotoUrl { get; set; }

        public string Baslik1 { get; set; }
        public string Aciklama1 { get; set; }

        public string Baslik2 { get; set; }
        public string Aciklama2 { get; set; }

        public string Baslik3 { get; set; }
        public string Aciklama3 { get; set; }

        public string Baslik4 { get; set; }
        public string Aciklama4 { get; set; }

        public string Baslik5 { get; set; }
        public string Aciklama5 { get; set; }

        public string Aciklama { get; set; }
        public string SeyahatTipi { get; set; }
        public string Tarih { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Mesaj { get; set; }
    }
}