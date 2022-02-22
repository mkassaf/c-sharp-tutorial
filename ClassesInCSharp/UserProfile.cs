using System;
namespace Users
{
    



    public class Person
    {
        private string last;
        private string first;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;

        }


        internal void print()
        {
            Console.WriteLine("first is {0} , last is {1}", first, last);
        }

        // Remaining implementation of Person class.
    }

    public class Adult : Person
    {
        private static int minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        { }

        static Adult()
        {
            minimumAge = 18;
        }

        // Remaining implementation of Adult class.


    }
}
