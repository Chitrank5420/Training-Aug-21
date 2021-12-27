using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public class SqlUserData : IUserData
    {
        private readonly FarmpeContext _farmpeContext;

        public SqlUserData(FarmpeContext farmpeContext)
        {
            _farmpeContext = farmpeContext;
        }

       
        public User EditUser(User user)
        {
            var myUser = _farmpeContext.Users.Find(user.UserId);
            if (myUser != null)
            {
                myUser.UserId = user.UserId;
                myUser.LastName = user.LastName;
                myUser.FirstName = user.FirstName;
                myUser.PhoneNo = user.PhoneNo;
                myUser.Email = user.Email;
                myUser.BirthDate = user.BirthDate;
                myUser.CreatedOn = user.CreatedOn;
                _farmpeContext.Users.Update(myUser);
                _farmpeContext.SaveChanges();
            }
            return myUser;
        }


    }
}
