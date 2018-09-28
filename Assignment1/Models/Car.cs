using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1
{
    public class Car
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public int Make { get; set; }
        public int Model { get; set; }
        public string Color { get; set; }

        public Car (int cost, int year, int make, int model, string color)
        {
            Cost = cost;
            Year = year;
            Make = make;
            Model = model;
            Color = color;
        }
        Car car1 = new Car(20000, 1990, 2000, 2000, "Black");
    }
}