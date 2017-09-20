using ITChallengeCompat.Logic;
using ITChallengeCompat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITChallengeCompat.Controllers
{
    public class UsersController : ApiController
    {
        private UserRepository2 _users;

        public UsersController()
        {
            _users = new UserRepository2();
        }

        [HttpGet]
        public IEnumerable<AppUser> Index()
        {
            return _users;
        }
    }
}
