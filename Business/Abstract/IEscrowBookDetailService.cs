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
    public interface IEscrowBookDetailService
    {
        List<EscrowBookDetail> GetAll();
        EscrowBookDetail GetById(int id);
        void Add(EscrowBookDetail escrow);
        void Update(EscrowBookDetail escrow);
        void Delete(EscrowBookDetail escrow);
        IDataResult<List<GetBooksInMember>> GetBooksInMember(int ReaderId);
        List<EscrowBookDetail> GetTeacherScreen();
    }
}
