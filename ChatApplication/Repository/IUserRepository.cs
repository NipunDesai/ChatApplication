using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Repository
{
   public interface IUserRepository
    {
        /// <summary>
        /// This method is can be used to Create a newuser.
        /// </summary>
        /// <param name="userdetail"> </param>
        UserDetail CreatenewUser(UserDetail userdetail);

       /// <summary>
       /// This method is can be used to Remove UserDetails
       /// </summary>
       /// <param name="userdetail"> </param>
       UserDetail RemoveUser(UserDetail userdetail);

        /// <summary>
        /// This method is can be used to Update UserDetails.
        /// </summary>
        /// <param name="userdetails"></param>
        UserDetail UpdateUser(UserDetail userdetails);

       /// <summary>
       /// This method is for Fatching Single User.
       /// </summary>
      /// <param name="userdetails"> </param>
        IEnumerable<UserDetail> GetUser(UserDetail userdetails);

       /// <summary>
       /// Get A all User.
       /// </summary>
     
       /// <returns></returns>
       IEnumerable<UserDetail> GetAllUser();


       
    }
}
