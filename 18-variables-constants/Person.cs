using System;

namespace _CSharpFund
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("My name is " + firstName + lastName);
        }
    }
}