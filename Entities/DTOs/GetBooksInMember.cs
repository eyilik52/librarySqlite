using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GetBooksInMember:IDto
    {
        
        public string BookName { get; set; }
        public int ReaderId { get; set; }
        public int BookId { get; set; }
        public int EscBookId { get; set; }
        public string AuthorName { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int EkranId { get; set; }
        //öğrenci:1,Öğretmen:2, pasif :0
    }
}
