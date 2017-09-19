using ITChallengeCompat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITChallengeCompat.Logic
{
    public class AppUserRepository
    {
        private Dictionary<int, AppUser> _users;

        public AppUserRepository()
        {
            _users = new Dictionary<int, AppUser>();
            _users[1] = new AppUser
            {
                Id = 1,
                Age = 21,
                Name = "Petras Suaugęs"
            };
            _users[2] = new AppUser
            {
                Id = 2,
                Age = 19,
                Name = "Marytė Faina"
            };
        }

        public IEnumerable<AppUser> ListAll()
        {
            return _users.Values;
        }
    }
}