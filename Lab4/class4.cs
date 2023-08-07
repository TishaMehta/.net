namespace ConsoleApp4
{
    internal abstract class class4
    {
       public abstract void SumOfTwo(int a, int b);
      public abstract void SumOfThree(int a, int b, int c);
       
    }
    class Calculate : class4
    {
        public override void SumOfTwo(int a, int b)
        {
            Console.WriteLine("ans = {0}", a + b);
        }

        public override void SumOfThree(int a, int b,int c)
        {
            Console.WriteLine("ans = {0}", a + b + c);
        }
    }
}