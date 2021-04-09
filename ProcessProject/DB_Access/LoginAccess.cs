using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessProject.DB_Access
{
    class LoginAccess
    {
        myDBDataContext db = new myDBDataContext();

        public bool getLogin(string username, string Pass)
        {
            var SqlQuery = from user in db.Logins
                           where user.username == username && user.password == Pass
                           select user;

            if (SqlQuery.Count() != 0) 
                return true;
            else return false;
        }
    }
}
