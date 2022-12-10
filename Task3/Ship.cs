using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Ship : Vehicle
    {
        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year) : base(xLocation, yLocation, price, speed, year)
        {

        }

        public Ship(uint price, uint speed, uint year) : base(price, speed, year)
        {

        }

        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if(passengers < 0)
                {
                    Console.WriteLine("Количество пассажиров не может быть отрицательным");
                } else
                {
                    passengers = value;
                }
            }
        }

        private string port;
        public string Port
        {
            get 
            {
                if(port == null)
                {
                    return "Порт не задан";
                }
                return port; 
            }
            set
            {
                if(value == null)
                {
                    Console.WriteLine("Значение не задано");
                } else
                {
                    port = value;
                }
            }
        }
    }
}
