using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAccessModifier
{
    public class Bicycle : SellBicycle
    {
        public int Wheels { get; set; }
        public void StartBicycle()
        {
            Console.WriteLine("Bicycle Started");
        }

        public void AttachedWheel()
        {
            Console.WriteLine($"You have attached {Wheels} wheels");
        }

        public void GenerateInvoice()
        {
            var bicycle = new Bicycle();
            bicycle.SetPrice(100);
            bicycle.Ammount = 2;
            bicycle.Invoice();

        }
    }
}
