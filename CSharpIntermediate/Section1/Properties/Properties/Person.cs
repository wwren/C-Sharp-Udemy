using System;

namespace Properties
{  
    public class Person
    {
        public DateTime BirthDate { get; private set; }
        public string UserName { get; set; }
        public string Name { get; set; }

        public Person (DateTime birthday)
	    {
        BirthDate = birthday;
	    }

        public int Age {
            get {
                var daySpan = DateTime.Today - BirthDate;
                var year = daySpan.Days/365;
               

                return daySpan;
            }
        }
    }
}