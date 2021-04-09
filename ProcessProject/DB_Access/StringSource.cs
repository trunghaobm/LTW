using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessProject.DB_Access
{
    class StringSource
    {


        private string remember = "admin\nadmin";
        private bool checkLogin = false;

        public string Remember
        {
            get { return remember; }
            set { remember = value; }
        }

        public bool CheckLogin
        {
            get { return checkLogin; }
            set { checkLogin = value; }
        }
    }
}
