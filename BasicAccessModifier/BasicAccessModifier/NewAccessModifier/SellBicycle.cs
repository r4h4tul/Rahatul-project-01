using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAccessModifier
{
   public class SellBicycle
    {
        private  int _price;
        protected int Price { get; set; }

        protected int Ammount { get; set; }

        protected void SetPrice(int price)
        {
            _price = price;
        }

        public void Invoice()
        {
            Console.WriteLine($"Your total is {_price * Ammount}");
        }
    }
}
