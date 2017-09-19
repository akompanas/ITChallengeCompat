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
        private AppUserRepository _users;

        public UsersController(AppUserRepository users)
        {
            _users = users;
        }

        [HttpGet]
        public IEnumerable<AppUser> Index()
        {
            return _users.ListAll();
        }

        [HttpPost]
        public void Update(AppUser user)
        {
            var existingUser = _users.Get(user.Id);
            existingUser.Name = user.Name;
            existingUser.Age = user.Age;
        }
    }
}
