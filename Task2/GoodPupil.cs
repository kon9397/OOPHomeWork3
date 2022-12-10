using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится хорошо!");
        }

        public override void Read()
        {
            Console.WriteLine($"{FirstName} читает хорошо!");
        }

        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет хорошо!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{FirstName} отдыхает хорошо!");
        }
    }
}
