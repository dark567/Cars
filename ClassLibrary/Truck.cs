using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Truck : Car
    {
        public int СarryingСapacity { get; set; }

        public int Insurance { get; set; }

        public int Mileage { get; set; }

        public Truck(string type, string color, decimal price, int carryingСapacity, int insurance, int mileage) : base(type, color, price)
        {
            this.СarryingСapacity = carryingСapacity;
            this.Insurance = insurance;
            this.Mileage = mileage;
            this.Discount = 30;
        }


    }
}
