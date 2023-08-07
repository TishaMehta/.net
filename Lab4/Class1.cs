namespace ConsoleApp4
{
    internal class Class1
    {
        public void getZeroDIvisionError()
        {
            try
            {
                Console.WriteLine("entre A:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("entre B:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ans :{0}", a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}