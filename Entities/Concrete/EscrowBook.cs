using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EscrowBook:IEntity
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int EkranId { get; set; }
        //öğrenci:1,Öğretmen:2, pasif :0
    }
}
