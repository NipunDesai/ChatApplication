using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace ChatApplication.Repository
{
    public class UserRepository :IUserRepository 
    {

        private ChatContext db = new ChatContext();
     
        //private readonly UserDetail _userDetailRepository;
        
     
      
        public UserDetail CreatenewUser(UserDetail userdetail)
        {
            db.UserDetails.Add(userdetail);
            db.SaveChanges();
            return userdetail;
        }

        public UserDetail RemoveUser(UserDetail userdetail)
        {
            throw new NotImplementedException();
        }

        public UserDetail UpdateUser(UserDetail userdetails)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDetail> GetUser(UserDetail userdetails)
        {
            throw new NotImplementedException();
        }

  

        public IEnumerable<UserDetail> GetAllUser()
        {
            return db.UserDetails.ToList();
        }
    }
}