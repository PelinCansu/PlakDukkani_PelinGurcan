using PlakDukkani.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Entities.Concrete
{
    public class Album:BaseEntity
    {
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal IndirimOrani { get; set; }
        public bool SatisDurumu { get; set; }


    }
}
