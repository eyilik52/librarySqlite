using Business.Abstract;
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
    public class EscrowBookDetailManager : IEscrowBookDetailService
    {

        IEscrowBookDetailDal _escrowBookDetailDal;
        public EscrowBookDetailManager(IEscrowBookDetailDal escrowBookDetailDal)
        {
            _escrowBookDetailDal = escrowBookDetailDal;
        }
        public void Add(EscrowBookDetail escrow)
        {
            _escrowBookDetailDal.Add(escrow);            
        }

        public void Delete(EscrowBookDetail escrow)
        {
            _escrowBookDetailDal.Delete(escrow);
        }

        public List<EscrowBookDetail> GetAll()
        {
            return _escrowBookDetailDal.GetAll();
        }

        public IDataResult<List<GetBooksInMember>> GetBooksInMember(int ReaderId)
        {
            return new SuccessDataResult<List<GetBooksInMember>>(_escrowBookDetailDal.GetBooksInMember().Where(p => p.ReaderId == ReaderId & p.EkranId == 1).ToList());
        }

        public EscrowBookDetail GetById(int id)
        {
            return _escrowBookDetailDal.Get(p => p.Id == id);
        }
        public List< EscrowBookDetail> GetReaderandBookId(int readerId,int bookId)
        {
            return _escrowBookDetailDal.GetAll().Where(p => p.ReaderId == readerId & p.BookId==bookId).ToList();
        }

        public List<EscrowBookDetail> GetTeacherScreen()
        {
            return _escrowBookDetailDal.GetAll().Where(p => p.EkranId == 2).ToList();
        }

        public void Update(EscrowBookDetail escrow)
        {
            _escrowBookDetailDal.Update(escrow);
        }

        public List<EscrowBookDetail> GetKitapKurdu()
        {
            return _escrowBookDetailDal.GetKitapKurdu();


        }
        public int Notlar(int ıd)
        {
            return _escrowBookDetailDal.NotToplamlari(ıd);
        }

    }
}
