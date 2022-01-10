using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constans;
using Entities.DTOs;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Messages.SaveAll);
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), "Hata 1");
        }

        public IDataResult<List<Book>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(p => p.CategoryId == categoryId));
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(p => p.Id == bookId));
        }

        public IDataResult<List<BookOrCategoryDetails>> GetCategorySearch(string key)
        {
            return new SuccessDataResult<List<BookOrCategoryDetails>>(_bookDal.GetBookOrCategoryDetails().Where(p => p.CategoryName.ToLower().Contains(key.ToLower().Trim())).ToList());
        }

        public IDataResult<List<BookOrCategoryDetails>> GetBookOrCategoryDetails()
        {
            return new SuccessDataResult<List<BookOrCategoryDetails>>(_bookDal.GetBookOrCategoryDetails());
        }

        public IDataResult<List<BookOrCategoryDetails>> GetBookSearch(string key) //kt => kt.Alan.ToLower().Contains(kelime.ToLower()) küçük büyük harf duyarlılığı engelleme::Hakkı Eyilik
        {
            return new SuccessDataResult<List<BookOrCategoryDetails>>(_bookDal.GetBookOrCategoryDetails().Where(p => p.BookName.ToLower().Contains(key.ToLower().Trim())).ToList());
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult();
        }
    }
}
