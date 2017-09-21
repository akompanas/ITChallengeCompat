using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient
{
    public class ClientUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public string Hobby { get; set; }

        public override string ToString()
        {
            //return Name + " (id=" + Id + ", age=" + Age + ")";
            //return string.Format("{0} (id={1}, age={2})", Name, Id, Age);
            return $"{Name} (id={Id}, age={Age})";
        }
    }
}
