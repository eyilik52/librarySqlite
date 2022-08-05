using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReaderManager : IReaderService
    {
        IReaderDal _readerDal;
        public ReaderManager(IReaderDal readerDal)
        {
            _readerDal = readerDal;
        }

        public IResult Add(Reader reader)
        {
            _readerDal.Add(reader);
            return new SuccessResult(Messages.SaveAll);
        }

        public IResult Delete(Reader reader)
        {
            _readerDal.Delete(reader);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Reader>> GetAll()
        {
            return new SuccessDataResult<List<Reader>>(_readerDal.GetAll(p=>p.IsActive==true), "Hata");
        }

        public IDataResult<List<Reader>> GetAllByClassId(int classId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Reader> GetById(int readerId)
        {
            return new SuccessDataResult<Reader>(_readerDal.Get(p => p.Id == readerId));
        }

        public IDataResult<List<ReaderDetails>> GetClassSearch(int key)
        {
            return new SuccessDataResult<List<ReaderDetails>>(_readerDal.GetReaderDetails().Where(p => p.ClassRoom.ToString().Contains(key.ToString())).ToList());
        }

        public IDataResult<List<ReaderDetails>> GetNameSearch(string key)
        {
            return new SuccessDataResult<List<ReaderDetails>>(_readerDal.GetReaderDetails().Where(p => p.ReaderName.ToLower().Contains(key.ToLower().Trim())).ToList());
        }

        public IDataResult<List<ReaderDetails>> GetSurnameSearch(string key)
        {
            return new SuccessDataResult<List<ReaderDetails>>(_readerDal.GetReaderDetails().Where(p => p.ReaderSurname.ToLower().Contains(key.ToLower().Trim())).ToList());
        }

        public IDataResult<List<ReaderDetails>> GetTCKNSearch(string key)
        {
            return new SuccessDataResult<List<ReaderDetails>>(_readerDal.GetReaderDetails().Where(p => p.TCKN.ToLower().Contains(key.ToLower().Trim())).ToList());
        }


        public IDataResult<List<ReaderDetails>> GetReaderDetails()
        {
            return new SuccessDataResult<List<ReaderDetails>>(_readerDal.GetReaderDetails());
        }

        public IResult Update(Reader reader)
        {
            _readerDal.Update(reader);
            return new SuccessResult(Messages.Update);
        }

       

        public IDataResult<Reader> GetByLoginReaderId(int id)
        {
            return new SuccessDataResult<Reader>(_readerDal.Get(p => p.Id == id && p.IsActive == true));
        }

        public IDataResult<Reader> GetByReaderTc(string key)
        {
            return new SuccessDataResult<Reader>(_readerDal.Get(p => p.Tc == key));
        }       

        public IDataResult<Reader> GetByPassword(string key)
        {
            return new SuccessDataResult<Reader>(_readerDal.Get(p => p.Password == key));
        }

        public IResult checkLogin(string readerTc, string password)
        {
            if (GetByReaderTc(readerTc).Data == null)
            {
                return new ErrorResult("Kullanici adi bulunamadi");
            }
            else if (GetByPassword(password).Data == null)
            {
                return new ErrorResult("Sifre bulunamadi");
            }
            else
            {
                return new SuccessResult();
            }
        }

        public IResult CheckUser(Reader reader)
        {
            throw new NotImplementedException();
        }
    }
}
