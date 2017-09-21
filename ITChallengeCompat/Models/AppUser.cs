using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITChallengeCompat.Models
{
    public class AppUser
    {
        public UserFields AvailableFields { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> HobbyList { get; set; }
    }

    [Flags]
    public enum UserFields
    {
        Hobby, Motto
    }

    public class AppUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; } = "<Hobby_not_sent>";
        public List<string> HobbyList { get; set; }
    }


}