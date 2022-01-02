﻿using Core.Utilities.Results;
using Entities.Concrete;
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

        IDataResult<List<Book>> GetById(int bookId);
        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);
    }
}
