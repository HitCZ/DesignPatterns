using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ImmutableObject
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
