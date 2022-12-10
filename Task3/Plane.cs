using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Plane : Vehicle
    {
        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year) : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Plane(uint price, uint speed, uint year) : base(price, speed, year)
        {

        }

        public int Height { get; set; }
        private int passengers;

        public int Passengers
        {
            get { return passengers; }
            set
            {
                if(passengers < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть отрицательным");
                } 
                else
                {
                    passengers = value;
                }
            }
        }
    }
}
