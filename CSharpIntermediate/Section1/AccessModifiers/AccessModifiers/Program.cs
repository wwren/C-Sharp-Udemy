
using System;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate; //_naming convention

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.GetType());
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());

        }
    }
}
