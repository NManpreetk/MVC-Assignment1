using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment1
{
    public class House
    {
        public int Value { get; set; }
        public double LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; } 
        public string PostalCode { get; set; }

        public House(int value, double lotSize, string address, string city, string state, string postalCode)
        {
            Value = value;
            LotSize = lotSize;
            Address = address;
            City = city;
            State = state; ;
            PostalCode = postalCode;
        }

        House house1 = new House(24000, 4.5, "40 king street", "Winnipeg", "Manitoba", "R3T4V5");
    }
}