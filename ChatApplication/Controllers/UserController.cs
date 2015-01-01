using ChatApplication.Models;
using ChatApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Security;

namespace ChatApplication.Controllers
{
    public class UserController : ApiController
    {
        IUserRepository _userRepository;
        private ChatContext db = new ChatContext();
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            var user = db.Users.ToList();
            return Ok(user);
           
        }
    }
}
