namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            var takeName = Console.ReadLine();
            Console.WriteLine("Hello " + takeName);

            Console.WriteLine("              ");
            Console.WriteLine("Please Enter Your Password");
            var password = Console.ReadLine();
            Console.WriteLine("Welcome " +  password);
            Console.ReadKey();
        }
    }
}