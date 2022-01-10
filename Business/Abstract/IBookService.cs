using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByCategoryId(int categoryId);
        IDataResult<Book> GetById(int bookId);
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
        IDataResult<List<BookOrCategoryDetails>> GetBookOrCategoryDetails();
        IDataResult<List<BookOrCategoryDetails>> GetCategorySearch(string key);
    }
}
