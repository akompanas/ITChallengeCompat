using ITChallengeCompat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITChallengeCompat.Logic
{
    public class UserRepository2 : List<AppUser>
    {
        public UserRepository2()
        {
            Add(new AppUser
            {
                Id = 1,
                Age = 21,
                Name = "Petras Suaugęs",
                HobbyList = new string[] { "Futbolas" }.ToList()
            });

            Add(new AppUser
            {
                Id = 2,
                Age = 18,
                Name = "Marytė Melnikaitė",
                HobbyList = new string[] { "Siuvinėjimas", "Boksas" }.ToList()
            });
        }
    }
}