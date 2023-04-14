using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    public class Class1
    {
        string userN = "";
        string passN = "";

        public Class1(string user, string pass)
        {
            this.userN = user;
            this.passN = pass;  
        }
        public Class1()
        {
            getUser();
            getPass();
        }

        public string getUser()
        {
            return userN;
        }
        public string getPass()
        {
            return passN;
        }

    }
}
