using System.ComponentModel.DataAnnotations;

namespace ykmturr.Models.Sınıflar
{
    public class icon
    {
        [Key]
        public int ID { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }
    }
}