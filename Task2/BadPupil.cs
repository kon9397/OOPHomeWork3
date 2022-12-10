using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BadPupil : Pupil
    {
        public BadPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится плохо!");
        }

        public override void Read()
        {
            Console.WriteLine($"{FirstName} не умеет читать!");
        }

        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет квакозябрами!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{FirstName} бездельничает!");
        }
    }
}
