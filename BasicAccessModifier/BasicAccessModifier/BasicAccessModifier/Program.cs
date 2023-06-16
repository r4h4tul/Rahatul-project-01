using NewAccessModifier;

namespace BasicAccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           // BaseClass.count = 0;

            Bicycle bicycle = new Bicycle();
            bicycle.Wheels = 3;
            bicycle.AttachedWheel();
            bicycle.StartBicycle();
            bicycle.GenerateInvoice();
        }
    }
}