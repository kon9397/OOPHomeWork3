using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private Pupil pupil1;
        private Pupil pupil2;
        private Pupil pupil3;
        private Pupil pupil4;

        public Pupil Pupil1
        {
            get { return pupil1; }
        }

        public Pupil Pupil2
        {
            get { return pupil2; }
        }

        public Pupil Pupil3
        {
            get { return pupil3; }
        }

        public Pupil Pupil4
        {
            get { return pupil4; }
        }

        public ClassRoom(Pupil pupil1)
        {
            this.pupil1 = pupil1;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.pupil1 = pupil1;
            this.pupil2 = pupil2;
            this.pupil3 = pupil3;
            this.pupil4 = pupil4;
        }
    }
}
