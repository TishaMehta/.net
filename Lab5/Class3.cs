namespace ConsoleApp5
{
    internal class Class3
    {
        public void area(int r)
        {
            Console.WriteLine("Area of circle : {0}", 3.14 * r * r);
        }
        public void area(double l)
        {
            Console.WriteLine("Ans of square : {0}", l * l);
        }
        public void area(int l, int b)
        {
            Console.WriteLine("Ans of triangle : {0}", l * b);
        }
    }
}