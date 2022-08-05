using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEscrowBookDetailDal : EfEntityRepositoryBase<EscrowBookDetail, LibraryContext>, IEscrowBookDetailDal
    {
        public List<GetBooksInMember> GetBooksInMember()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from e in context.escrowBookDetails
                             join b in context.Books
                             on e.BookId equals b.Id
                             join r in context.Readers
                             on e.ReaderId equals r.Id
                             join escr in context.EscrowBooks
                             on e.ReaderId equals escr.ReaderId
                             select new GetBooksInMember
                             {
                                 AuthorName = b.AuthorName,
                                 BookName = b.BookName,
                                 ReaderId = r.Id,
                                 BookId = b.Id,
                                 EkranId = e.EkranId,
                                 DeliveryDate = escr.DeliveryDate,
                                 TransactionDate = escr.TransactionDate,
                                 EscBookId =e.Id
                             };


                return result.ToList();

            }
        }

        
    }
}