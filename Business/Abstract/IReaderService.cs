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
    public interface IReaderService
    {
        IDataResult<List<Reader>> GetAll();
        IDataResult<List<Reader>> GetAllByClassId(int classId);
        IDataResult<Reader> GetById(int readerId);
        IResult Add(Reader reader);
        IResult Update(Reader reader);
        IResult Delete(Reader reader);
        IDataResult<List<ReaderDetails>> GetReaderDetails();
        IDataResult<List<ReaderDetails>> GetClassSearch(int key);

    }
}
