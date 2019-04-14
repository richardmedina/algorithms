using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DesignPatterns.GangOfFour.Creational.Prototype
{
    public class PersonalInformation : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        public object Clone()
        {
            return new PersonalInformation
            {
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth
            };
        }
    }
}
