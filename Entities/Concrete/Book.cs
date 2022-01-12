using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string BarcodeNumber { get; set; }        
        public int CategoryId { get; set; }        
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }
        public int Stock { get; set; }
        public int YearOfPublication { get; set; }
        public char CabinetNumber { get; set; }
        public int ShelfNo { get; set; }//Raf No
        public int AssetNumber { get; set; }//Demirbaş No
        public int NumberOfPages { get; set; }         
        public bool IsActive { get; set; } = true;
    }
}
