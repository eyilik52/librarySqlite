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
                             //join escr in context.EscrowBooks
                             //on e.ReaderId equals escr.ReaderId
                             select new GetBooksInMember
                             {
                                 AuthorName = b.AuthorName,
                                 BookName = b.BookName,
                                 ReaderId = r.Id,
                                 BookId = b.Id,
                                 EkranId = e.EkranId,
                                 SayfaSayisi = b.NumberOfPages,
                                 DeliveryDate = DateTime.Now,
                                 //TransactionDate = escr.TransactionDate,
                                 EscBookId =e.Id
                             };


                return result.ToList();

            }
        }

        public List<EscrowBookDetail> GetKitapKurdu()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = context.escrowBookDetails.Where(p => p.EkranId == 0)
                   .GroupBy(p => p.ReaderId)
                   .Select(g => new EscrowBookDetail { ReaderId = g.Key, BookId = g.Count() });

                return result.ToList();
            }
        }

        public int NotToplamlari(int readerıd)
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = context.escrowBookDetails.Where(p => p.ReaderId == readerıd && p.EkranId==0).Sum(p => p.Notu);
                return result;

            }
        }

        
    }
}