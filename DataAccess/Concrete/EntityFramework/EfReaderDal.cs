using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfReaderDal : EfEntityRepositoryBase<Reader, LibraryContext>, IReaderDal
    {
        public List<ReaderDetails> GetReaderDetails()
        {
            using (LibraryContext context=new LibraryContext())
            {
                var result = from r in context.Readers
                             where r.IsActive == true
                             select new ReaderDetails
                             {
                                  ReaderId=r.Id,
                                   ReaderName=r.Name,
                                    ReaderSurname=r.Surname,
                                     ClassRoom=r.ClassRoomId,
                                      Branch=r.ClassRoombranch,
                                       TCKN=r.Tc,
                                        TelefonNO=r.Phone                                         
                                        
                                     
                             };
                return result.ToList();
            }
        }
    }
}
