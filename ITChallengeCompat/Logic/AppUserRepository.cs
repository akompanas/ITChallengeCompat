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
        }

        public IEnumerable<AppUser> ListAll()
        {
            return _users.Values;
        }
    }
}