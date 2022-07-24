using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        IDataResult<User> GetByUserName(string key);
        IResult CheckUser(User user);
        IDataResult<User> GetByPassword(string key);
        IResult checkLogin(string userName, string password);
    }
}
