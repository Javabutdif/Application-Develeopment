using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppsDev
{
    public class Civil
    {
        private static List<Civil> list = new List<Civil>();
     

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

        public Civil(string id, string l, string f, string m, string bm, string bd, string by, string age, string sex, string status, string religion, string bp, string pn, string add, string idP, string idnum, string email)
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
            this.idNum = idnum;
            this.email = email;
        }
        public Civil()
        {

        }
        



        public void setData()
        {
            SearchTab tab = new SearchTab();


            deleteAll();

            int count;
            for (count = 0; count < File.ReadAllLines(tab.passData).Length; count++)
            {
                 string[] frag = File.ReadAllText(tab.passData).Split("\n");
                string[] us = frag[count].Split(",");

                Civil c = new Civil(us[0], us[1], us[2], us[3], us[4], us[5], us[6], us[7], us[8], us[9], us[10], us[11], us[12], us[13], us[14], us[15], us[16]);
               
                list.Add(c);

            }
            
          

        }
        public void deleteAll()
        {
           
            list.Clear();
        }
       


        public void remove(Civil civil)
        {
            list.Remove(civil);
        }
     
      
        public List<Civil> getData()
        {
            return list;
        }
        
        
        public Civil getList(string search)
        {
            Civil? user = list.Where(user => user.Lastname.Equals(search) || user.id.Equals(search) || user.firstname.Equals(search)).FirstOrDefault();

            if (user != null)
            {
                this.lastname = user.lastname;
                this.firstname = user.firstname;
                this.middlename = user.middlename;
                this.birthM = user.birthM;
                this.birthDate = user.birthDate;
                this.birthYear = user.birthYear;
                this.age = user.age;
                this.sex = user.sex;
                this.status = user.status;
                this.religion = user.religion;
                this.birthPlace = user.birthPlace;
                this.phoneNumber = user.phoneNumber;
                this.address = user.address;
                this.ID = user.ID;
                this.idNum = user.idNum;
                this.email = user.email;
                this.id = user.reference;
            }
            else
            {
                user = null;
            }

            return user;
        }
       

       
        public string Lastname { get { return this.lastname; } }
        public string Firstname { get { return this.firstname; } }
        public string MIDdlename { get { return this.middlename; } }
        public string BirthM { get { return this.birthM; } }
        public string BirthD { get { return this.birthDate; } }
        public string BirthYear { get { return  this.birthYear; } }
        public string BirthPlace { get {  return this.birthPlace; } }
        public string PhoneNumber { get {  return this.phoneNumber; } }
        public string Address { get { return this.address; } }
        public string identification { get { return this.ID; } }
        public string Email { get { return this.email; } }
        public string idNumber { get { return this.idNum; } }
        public string reference { get { return this.id; } }
        public string Age { get { return this.age; } }
        public string Sex { get { return this.sex; } }
        public string Religion { get { return this.religion; } }
        public string Status { get { return this.status; } }


    }
}
