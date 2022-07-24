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
    public class EscrowBookManager : IEscrowBookService
    {
        IEscrowBookDal _escrowBookDal;
        public EscrowBookManager(IEscrowBookDal escrowBookDal)
        {
            _escrowBookDal = escrowBookDal;
        }
        public IResult Add(EscrowBook escrowBook)
        {
            _escrowBookDal.Add(escrowBook);
            return new SuccessResult(Messages.SaveAll);
        }

        public IDataResult<List<BookDeliveredMember>> BookDeliveredMember()
        {
            return new SuccessDataResult<List<BookDeliveredMember>>(_escrowBookDal.GetBookDeliveredMembers());
        }
        

        public IResult Delete(EscrowBook escrowBook)
        {
            _escrowBookDal.Delete(escrowBook);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<EscrowBook>> GetAll()
        {
            return new SuccessDataResult<List<EscrowBook>>(_escrowBookDal.GetAll(), "Hata 1");
        }

        public IDataResult<List<EscrowBook>> GetAllEscrowReaderId(int readerId)
        {
            return new SuccessDataResult<List<EscrowBook>>(_escrowBookDal.GetAll(p => p.ReaderId == readerId));
        }

        public IDataResult<List<GetBooksInMember>> GetBooksInMember(int ReaderId)//üyelerdeki kitaplar
        {
            return new SuccessDataResult<List<GetBooksInMember>>(_escrowBookDal.GetBooksInMember().Where(p => p.ReaderId == ReaderId).ToList());
        }        

        public IDataResult<EscrowBook> GetById(int escrowBookId)
        {
            return new SuccessDataResult<EscrowBook>(_escrowBookDal.Get(p => p.Id == escrowBookId));
        }

        public IDataResult<List<BookDeliveredMember>> GetEscrowBookSearchDate(DateTime dateTime1, DateTime dateTime2)
        {
            return new SuccessDataResult<List<BookDeliveredMember>>(_escrowBookDal.GetAllBookDeliveredMembers().Where(p => p.DeliveryDate > dateTime1 & p.DeliveryDate < dateTime2).ToList());
        }

        public IDataResult<List<BookDeliveredMember>> NonDeliveredMember()
        {
            return new SuccessDataResult<List<BookDeliveredMember>>(_escrowBookDal.GetBookDeliveredMembers().Where(p=>p.DeliveryDate <= DateTime.Now).ToList());
        }

        public IResult Update(EscrowBook escrowBook)
        {
            _escrowBookDal.Update(escrowBook);
            return new SuccessResult(Messages.Update);
        }
    }
}
