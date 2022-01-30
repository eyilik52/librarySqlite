using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BookDeliveredMember
    {
        public int EscrowBookId { get; set; }        
        public string BookName { get; set; }
        public string ReaderName { get; set; }
        public string ReaderSurname { get; set; }
        public string AuthorName { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
