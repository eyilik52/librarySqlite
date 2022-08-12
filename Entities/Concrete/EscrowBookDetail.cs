using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EscrowBookDetail:IEntity
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public bool IsActive { get; set; } = true;
        public string Konu { get; set; }
        public string AnaFikir { get; set; }
        public int EkranId { get; set; }
        //öğrenci:1,Öğretmen:2, pasif :0
        public int BookId { get; set; }
        public string Zaman { get; set; }
        public string Mekan { get; set; }
        public string AnlaticiTuru { get; set; }
        public string KisiKadrosu { get; set; }
        public string KitapBegenildimi { get; set; }
        public string Tavsiye { get; set; }
        public string SizceKitapSonu { get; set; }
        public string EniyiIfade { get; set; }
        public int Notu { get; set; }  
    }
}
