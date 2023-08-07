using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Class5
    {
   
            public delegate void factorial(int a);
            
                int mul = 1;
                public void fact(int a)
        {
            for(int i = 0; i <= a; i++)
            {
                mul *= i;
            }
            Console.WriteLine("Factorial : {0}", mul);
        }
            }
        }
    
