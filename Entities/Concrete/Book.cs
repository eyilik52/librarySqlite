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
        public string BarcodeNumber { get; set; }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ClassRoomId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int NumberOfPages { get; set; }        
        public bool IsActive { get; set; } = true;
    }
}
