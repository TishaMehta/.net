using System;

namespace ConsoleApp1
{
    internal class Class2
    {
        static String name, country;
        public Class2()
        {

        }
        public void getDetail()
        {
            Console.WriteLine("Enter Your Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Country Name :");
            country = Console.ReadLine();

        }
        public void setDetail()
        {
            Console.WriteLine("Hello {0} from {1}", name, country);
        }
    }
}