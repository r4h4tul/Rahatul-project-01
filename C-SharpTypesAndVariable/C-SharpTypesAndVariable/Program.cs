using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpTypesAndVariable
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //int userAge = 0;
    //        //Console.WriteLine(userAge);
    //        //Console.Read();

    //        //int x = 10; //Ref types
    //        //int y = x;
    //        //x = 30;
    //        //Console.WriteLine("X = " + x);
    //        //Console.WriteLine("Y = " + y);
    //        //Console.Read();

    //        //int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
    //        //int[] array2 = array1;
    //        //Console.WriteLine("array1[0] " + array1[0]);
    //        //Console.WriteLine("array2[0] " + array2[0]);
    //        //array1[0] = 10;
    //        //Console.WriteLine("array1[0] " + array1[0]);
    //        //Console.WriteLine("array2[0] " + array2[0]);
    //        //Console.ReadKey();

    //        //int num1 = 20;
    //        //int num2 = 25;
    //        //int sum = num1 + num2;
    //        //Console.WriteLine("num1: {0} + num2: {1} = sum:{2}",num1,num2,sum);
    //        //Console.ReadKey();
    //    }   
    //}


    //public enum DayOfWeek
    //{
    //    Saturday,
    //    Sunday,
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,


    //}
    //public class DaysOfWeek
    //{
    //    static void Main(String[] args)
    //    {
    //        DayOfWeek today = DayOfWeek.Sunday;
    //        Console.WriteLine("Today is " + today);

    //        if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
    //        {
    //            Console.WriteLine("Today is weekend");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Today is Week Day");
    //        }
    //        Console.Read();
    //    }
    //}


    //struct Point
    //{
    //    public int x;
    //    public int y;
    //}
    //public class Pointer
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p;
    //        p.x = 5;
    //        p.y = 10;

    //        Console.WriteLine("Point Coordinates: X: {0}, Y: {1} ", + p.x, p.y);
    //        Console.Read();
    //    }
    //}


   public class BuildInTupple
    {
        static void Main(string[] args)
        {
            Tuple<int, string> person = new Tuple<int, string> ( 23, "Rahatul" );
            Console.WriteLine( "Person: Age ={0} , Name = {1} " , person.Item1,person.Item2);
            Console.Read();

        }
    }
}
