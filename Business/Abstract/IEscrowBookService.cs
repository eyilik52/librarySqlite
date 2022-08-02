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
    public interface IEscrowBookService
    {
        IDataResult<List<EscrowBook>> GetAll();
        IResult Add(EscrowBook escrowBook);
        IResult Delete(EscrowBook escrowBook);
        IResult Update(EscrowBook escrowBook);
        IDataResult<List<BookDeliveredMember>> BookDeliveredMember();
        IDataResult<List<BookDeliveredMember>> NonDeliveredMember();        
        IDataResult<List<EscrowBook>> GetAllEscrowReaderId(int readerId);
        IDataResult<EscrowBook> GetById(int escrowBookId);
        IDataResult<List<BookDeliveredMember>> GetEscrowBookSearchDate(DateTime dateTime1, DateTime dateTime2);
    }
}
