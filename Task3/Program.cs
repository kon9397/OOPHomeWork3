using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(15000, 150, 2004) { Port = "Южный, Одесская область", Passengers = 40 };
            Console.WriteLine($"Ship: Кол-во пассажиров: {ship.Passengers}, Цена: {ship.Price}, Скорость: {ship.Speed}, Год: {ship.Year}");
            Car car = new Car(4000, 180, 1997);
            Console.WriteLine($"Car: Цена: {car.Price}, Скорость: {car.Speed}, Год: {car.Year}");
            Plane plane = new Plane(4000, 180, 1997) { Passengers = 45 };
            Console.WriteLine($"Plane: Кол-во пассажиров: {plane.Passengers} Цена: {plane.Price}, Скорость: {plane.Speed}, Год: {plane.Year}");

            Console.ReadKey();
        }
    }
}
