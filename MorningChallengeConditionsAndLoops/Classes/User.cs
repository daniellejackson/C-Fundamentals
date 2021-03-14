using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallengeConditionsAndLoops.Classes
{
    public class User
    { 
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public DateTime DateOfBirth { get; set; }


        public User(string firstName, String lastName, int idNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = idNumber;
            DateOfBirth = dateOfBirth;


        }



    }




}



