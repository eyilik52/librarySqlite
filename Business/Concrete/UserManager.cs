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
    public class UserManager : IUserService
    {
        IUserDal _userDal;    


        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public IResult checkLogin(string userName, string password)
        {
            if (GetByUserName(userName).Data == null)
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

        public IResult CheckUser(User user)
        {
            //if(_userDal.Get())
            //{
            //    
            //}
            //else if(_userDal.Get(p => p.Password.Contains(user.Password)) == null)
            //{
            //    
            //}
            //else
            //{
            //    return new SuccessResult();
            //}
            return new SuccessResult();
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(p=>p.UserId==id);
        }

        public IDataResult<User> GetByPassword(string key)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Password == key));
        }

        public IDataResult<User> GetByUserName(string key)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserName == key));
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }       

        
    }
}
