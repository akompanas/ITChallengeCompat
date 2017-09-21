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
        static private UserRepository2 _users = new UserRepository2();

        [HttpGet]
        public IEnumerable<AppUser> Index()
        {
            return _users;
        }

        [HttpPost]
        public void Update(AppUserDTO user)
        {
            AppUser domainUser = ConvertToDomainUser(user);
            var existingUser = _users.Single(u => u.Id == domainUser.Id);
            existingUser.Name = domainUser.Name;
            existingUser.Age = domainUser.Age;
            if (domainUser.AvailableFields.HasFlag(UserFields.Hobby))
                existingUser.HobbyList = domainUser.HobbyList;
        }

        private AppUser ConvertToDomainUser(AppUserDTO data)
        {
            var domainUser = new AppUser
            {
                Id = data.Id,
                Name = data.Name,
                Age = data.Age
            };
            if (data.HobbyList != null)
            {
                domainUser.HobbyList = data.HobbyList;
                domainUser.AvailableFields |= UserFields.Hobby;
            }
            else if (data.Hobby != "<Hobby_not_sent>")
            {
                domainUser.HobbyList = new List<string>(new string[] { data.Hobby });
                domainUser.AvailableFields |= UserFields.Hobby;
            }
            else
                domainUser.HobbyList = null;
            return domainUser;
        }
    }
}
