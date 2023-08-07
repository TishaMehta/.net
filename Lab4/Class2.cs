using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    internal class Class2
    {
 
            public void EndexOutOfBoundErro()
            {
                try
                {
                    int[] arr = new int[5];
                    for(int i = 0; i < 6; i++)
                    {
                        Console.WriteLine("entre  element:");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch(IndexOutOfRangeException e) {
                    Console.WriteLine(e);
                }
            }
        }
    }
