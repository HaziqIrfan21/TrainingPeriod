using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class studentClass
    {
        private int rollId;
        private string studentName;
        private int phoneNumber;
        private string address;

        public int RollId
        {
            get => rollId;
            set => rollId = value;
        }

        public string StudentName
        {
            get => studentName;
            set => studentName = value;
        }

        public int PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }


        //public studentClass(int tempRollId, string tempStudentName,int tempPhoneNumber,string tempAddress)
        //{
        //    rollId = tempRollId;
        //    studentName = tempStudentName;
        //    phoneNumber = 
        //}
    }
}
