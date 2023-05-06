using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    internal class Civil
    {
        public List<Civil> list = new List<Civil>();

        private string id = "";
        private string lastname = "";
        private string firstname = "";
        private string middlename = "";
        private string birthM = "";
        private string birthDate = "";
        private string birthYear = "";
        private string age = "";
        private string sex = "";
        private string status = "";
        private string religion = "";
        private string birthPlace = "";
        private string phoneNumber = "";
        private string address = "";
        private string ID = "";
        private string idNum = "";
        private string email = "";

        private Civil(string id, string l, string f, string m, string bm, string bd, string by, string age, string sex, string status, string religion, string bp, string pn, string add, string idP, string idnum, string email)
        {
            this.id = id;
            this.lastname = l;
            this.firstname = f;
            this.middlename = m;
            this.birthM = bm;
            this.birthDate = bd;
            this.birthYear = by;
            this.age = age;
            this.sex = sex;
            this.status = status;
            this.religion = religion;
            this.birthPlace = bp;
            this.phoneNumber = pn;
            this.address = add;
            this.ID = idP;
            this.idNum =idnum;
            this.email = email;
        }
        public Civil()
        {

        }

        
      
        public void setData()
        {
            SearchTab tab = new SearchTab();

           

            string[] info = File.ReadAllText(tab.passData).Split(",");

            int count;
            for (count = 0; count < File.ReadAllLines(tab.passData).Length; count++)
            {
                string[] frag = File.ReadAllText(tab.passData).Split("\n");
                string[] us = frag[count].Split(",");

                Civil c = new Civil(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10], us[11], us[12], us[13], us[14], us[15], us[16]);
                list.Add(c);

            }



         
        }
        public void getList(string search)
        {
            Civil? user = list.Where(user => user.Lastname.Equals(search) || user.id.Equals(search) || user.firstname.Equals(search)).FirstOrDefault();

            if (user != null)
            {
                this.lastname = user.lastname;
                this.firstname = user.firstname;
                this.middlename = user.middlename;
                this.id = user.reference;
            }

        }

       
        public string Lastname { get { return lastname; } }
        public string Firstname { get { return firstname; } }
        public string MIDdlename { get { return middlename; } }
        public string BirthM { get { return birthM; } }
        public string BirthD { get { return birthDate; } }
        public string BirthYear { get { return birthYear; } }
        public string BirthPlace { get {  return birthPlace; } }
        public string PhoneNumber { get {  return phoneNumber; } }
        public string Address { get { return address; } }
        public string identification { get { return ID; } }
        public string Email { get { return email; } }
        public string idNumber { get { return idNum; } }
        public string reference { get { return id; } }


    }
}
