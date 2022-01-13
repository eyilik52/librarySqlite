using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BookOrCategoryDetails:IDto
    {
        public int BookId { get; set; }
        public string BarcodeNumber { get; set; }
        public string BookName { get; set; }
        public string CategoryName { get; set; }
        public char CabinetNumber { get; set; }
        public string AuthorName { get; set; }
        public int ShelfNo { get; set; }//Raf No
        public int Stock { get; set; }
    }
}
