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
     
        private static string lastname = "";
        private static string firstname = "";
        private static string middlename = "";
        private static string birthM = "";
        private static string birthDate = "";
        private static string birthYear = "";
        private static string age = "";
        private static string sex = "";
        private static string status = "";
        private static string religion = "";
        private static string birthPlace = "";
        private static string phoneNumber = "";
        private static string address = "";
        private static string ID = "";
        private static string idNum = "";
        private static string email = "";

        
        public Civil() {

           
            setData();
        }
        private void setData()
        {
            SearchTab tab = new SearchTab();

           

            string[] info = File.ReadAllText(tab.passData).Split(",");
            lastname = info[0];
            firstname = info[1];
            middlename = info[2];
            birthM = info[3];   
            birthDate = info[4];
            birthYear = info[5];
            age = info[6];
            sex = info[7];
            status = info[8];
            religion = info[9];
            birthPlace = info[10];
            phoneNumber = info[11];
            address = info[12];
            ID = info[13];
            idNum = info[14];
            email = info[15];
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


    }
}
