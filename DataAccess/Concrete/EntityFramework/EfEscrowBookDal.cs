using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEscrowBookDal : EfEntityRepositoryBase<EscrowBook, LibraryContext>, IEscrowBookDal
    {
        public List<BookDeliveredMember> GetBookDeliveredMembers()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from e in context.EscrowBooks
                             join b in context.Books
                             on e.BookId equals b.Id
                             join r in context.Readers
                             on e.ReaderId equals r.Id
                             where e.IsActive == true
                             select new BookDeliveredMember
                             {
                                 AuthorName = b.AuthorName,
                                 BookName = b.BookName,
                                 DeliveryDate = e.DeliveryDate,
                                 EscrowBookId = e.Id,
                                 ReaderName = r.Name,
                                 ReaderSurname = r.Surname,
                                 TransactionDate = e.TransactionDate,
                                  BarkodNumber=b.BarcodeNumber
                             };


                return result.ToList();

            }
        }

        public List<BookDeliveredMember> GetAllBookDeliveredMembers()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from e in context.EscrowBooks
                             join b in context.Books
                             on e.BookId equals b.Id
                             join r in context.Readers
                             on e.ReaderId equals r.Id
                             select new BookDeliveredMember
                             {
                                 AuthorName = b.AuthorName,
                                 BookName = b.BookName,
                                 DeliveryDate = e.DeliveryDate,
                                 EscrowBookId = e.Id,
                                 ReaderName = r.Name,
                                 ReaderSurname = r.Surname,
                                 TransactionDate = e.TransactionDate
                             };


                return result.ToList();

            }
        }


    }


}

