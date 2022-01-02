using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return new SuccessResult();
        }

        public IResult Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult();
        }

        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll());
        }

        public IDataResult<List<Book>> GetById(int bookId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(c => c.Id == bookId));
        }

        public IResult Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult();
        }
    }
}
