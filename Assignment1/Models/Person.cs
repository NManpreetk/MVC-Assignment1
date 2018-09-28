using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public int DOB { get; set; }
        public string Email { get; set; }

        public Person (string firstName, string lastName, string nickName, string gender, int dob, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            Gender = gender;
            DOB = dob;
            Email = email;
        }
        Person person1 = new Person("John", "Doe", "JD", "Male", 30 - 09 - 1990, "JohnDoe@gmail.com");
    }
}