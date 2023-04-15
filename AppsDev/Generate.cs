using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    public class Generate
    {
        public string getReference()
        {
            Random rand = new Random(); 
            string reference = "";

            for(int i = 0; i< 8; i++)
            {
                reference += rand.Next(9);
            }

            return reference;
        }
    }
}
