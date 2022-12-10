using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Pupil
    {
        private string firstName;
        private string lastName;

        public Pupil (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        public string FirstName
        {
            get { return firstName; }
        }

        public string LastName
        {
            get { return lastName; }
        }

        public virtual void Study()
        {
            Console.WriteLine($"{firstName} учится!");
        }

        public virtual void Read()
        {
            Console.WriteLine($"{firstName} читает!");
        }

        public virtual void Write()
        {
            Console.WriteLine($"{firstName} пишет!");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"{firstName} отдыхает!");
        }
    }
}
