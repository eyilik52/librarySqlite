using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, LibraryContext>, IBookDal
    {
        public List<BookOrCategoryDetails> GetBookOrCategoryDetails()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from b in context.Books
                             join c in context.Categories
                             on b.CategoryId equals c.Id
                             //join Com in context.classRooms
                             //on b.ClassRoomId equals Com.Id
                             where b.IsActive == true
                             select new BookOrCategoryDetails
                             {
                                 BookId = b.Id,
                                 BarcodeNumber = b.BarcodeNumber,
                                 BookName = b.BookName,
                                 CategoryName = c.Name,
                                 Stock = b.Stock,
                                 

                                 //CompanyName = Com.Name,
                                 
                                 //SalePrice = p.SalePrice,


                             };
                return result.ToList();
            }
        }
    }
}
