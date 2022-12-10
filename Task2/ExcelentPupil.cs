using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Study()
        {
            Console.WriteLine($"{FirstName} учится великолепно!");
        }

        public override void Read()
        {
            Console.WriteLine($"{FirstName} читает лучше всех!");
        }

        public override void Write()
        {
            Console.WriteLine($"{FirstName} пишет понятно, красиво и четко!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{FirstName} отдыхает после плодотворной учебы!");
        }
    }
}
