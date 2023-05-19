using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    public class UserLogin
    {
        public string id ="";
        public string username = "";
        public string password = "";
        public string lastname = "";
        public string firstname = "";
        public string middlename = "";
        public string governId = "";
        public string region = "";
        public string province = "";
        public string city = "";
        public string barangay = "";

        public UserLogin(string id, string us, string p , string l, string f, string m, string g, string r, string prov, string city, string br)
        {
            this.id = id;
            this.username = us;
            this.password = p;
            this.lastname = l;
            this.firstname = f;
            this.middlename = m;
            this.governId = g;
            this.region = r;
            this.province = prov;
            this.city = city;
            this.barangay = br;
        }
        public UserLogin()
        {

        }
    }
}
