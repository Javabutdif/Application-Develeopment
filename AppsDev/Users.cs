using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    public class Users
    {
        private string allInfo = "";
        public Users() { 
        }

        public Users(string id,string username, string password, string info) {

            this.allInfo = id + "," + username + "," + password + "," + info;


        }

        public string getData()
        {
            return this.allInfo;
        }
    }
}
