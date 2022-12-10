using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(
                new ExcelentPupil("Кариша", "Тюшнякова"),
                new GoodPupil("Костя", "Sologub"),
                new BadPupil("Настя", "Кушнир"),
                new BadPupil("Руслан", "Стружук")
            );

            classRoom.Pupil1.Study();
            classRoom.Pupil1.Read();
            classRoom.Pupil1.Write();
            classRoom.Pupil1.Relax();

            classRoom.Pupil2.Study();
            classRoom.Pupil2.Read();
            classRoom.Pupil2.Write();
            classRoom.Pupil2.Relax();

            classRoom.Pupil3.Study();
            classRoom.Pupil3.Read();
            classRoom.Pupil3.Write();
            classRoom.Pupil3.Relax();

            classRoom.Pupil4.Study();
            classRoom.Pupil4.Read();
            classRoom.Pupil4.Write();
            classRoom.Pupil4.Relax();

            Console.ReadKey();
        }
    }
}
