using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataListsDemo
{
    class User
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public string FullName => $"{LastName}, {FirstName}";

        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString() => $"{FullName} - {Age}";
    }
}
