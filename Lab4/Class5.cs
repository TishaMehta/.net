namespace ConsoleApp4
{
    public interface Calculate1
    {
        void addition();
        void sub();
    }
    internal class Class5:Calculate1
    {
        public static int a, b;
        public void getdetails()
        {
            Console.WriteLine("entre a:");
             a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entre b:");
            b = Convert.ToInt32(Console.ReadLine());

        }
        public void addition()
        {
            Console.WriteLine("sum: {0}", a + b);
        }
        public void sub()
        {
            Console.WriteLine("sub: {0}", a - b);
        }
    }
}