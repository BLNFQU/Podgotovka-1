using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka_1
{
    class User
    {
        public static List<User> Users = new List<User>();

        public string Login { get; set; }
        public User (string login)
        {

            Login = login;
        }

    }
}
