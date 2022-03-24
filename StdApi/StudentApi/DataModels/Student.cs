using System;
using System.Collections.Generic;
using System.Linq;


namespace StudentApi.DataModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        public string Emailid { get; set; }
        public long MobileNo { get; set; }
        public string ProfileImg { get; set; }
        public Guid Genderid { get; set; }

        //Navigation property
        public Gender Gender { get; set; }

        public Address Address { get; set; }



    }
}
