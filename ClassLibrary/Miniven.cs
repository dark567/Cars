using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Miniven : Truck
    {
        public int CountPlaces { get; set; }

        public Miniven(string type, string color, decimal price, int countPlaces) : base(type, color, price, countPlaces)
        {
            this.Discount = 10;
        }

        public override int Discount
        {
            get
            {
                if (Price > 10000)
                {
                    return discount + 25;

                }
                return discount;
            }
            set
            {
                if (value <= 100)
                {
                    discount = value;
                }
                else
                {
                    Console.WriteLine("wrong discount size you are fraud");
                    discount = 0;
                }
            }
        }


    }
}
