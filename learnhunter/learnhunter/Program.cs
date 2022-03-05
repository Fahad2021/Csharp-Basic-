using learnhunter.Math;
using System;

namespace learnhunter
{
   public class Person
    {
        public string firstName = "abu";
        public string middle = "Saleh";
        public string lastName = "Md.Fahad";
        public string officeName = "Satcom";
        public string ghum = "12am";
        public string weakup = "6am";
        public string officetimem = "8.30";
        public string comebacoffice = "7.30";

        public void fullName()
        {
            Console.WriteLine("My name is" + " " + firstName + " " + middle + " " + lastName);
        }

        public void sleep()
        {
            Console.WriteLine("Ame ghumai"+" "+ ghum);
        }
        public void arise()
        {
            Console.WriteLine("Ghum theke Othi"+" "+weakup);
        }
        public void office()
        {
            Console.WriteLine("Office jai" + " " + officetimem);
        }
        public void bashayasi()
        {
            Console.WriteLine("Bashay asi ame" + " " + comebacoffice);
        }
        public void oficenam()
        {
            Console.WriteLine("Amr Office er Nam" + " " + officeName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.fullName();
            p1.oficenam();
            p1.office();
            p1.bashayasi();
            p1.sleep();
            p1.arise();

            var sum= Calculator.Add(2, 4);
            Console.WriteLine(sum);

            var area1 = Circle.Circle.Area(3.1416, 5);
            Console.WriteLine("The circle area is"+" "+area1);

            string[] Cars = { "toyta", "BMW", "ford" };
            var car1=Cars[0];
            Console.WriteLine(car1);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            var x = 10;
            while (x <= 20)
            {
                Console.WriteLine(x);
                x++;
            }

            var y = 40;
            do
            {
                Console.WriteLine(y);
                y++;
            } while (y<=50);

            int []num = { 1, 2, 3, 4 };
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
            
            
        }
    }
}
