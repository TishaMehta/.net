namespace ConsoleApp4
{
    public interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }
    internal class Class6:Shape
    {
        double r, b, h, l;
        public void getDetails()
        {
            Console.WriteLine("enter radious:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter base of triangle:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter height of triangle");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter length of square:");
            l = Convert.ToDouble(Console.ReadLine());
        }
        public void Circle()
        {
            Console.WriteLine("Area of circle: {0}", 3.14*r*r);
        }
        public void Triangle()
        {
            Console.WriteLine("Area of triangle :{0}", l*l);
        }
        public void Square()
        {
            Console.WriteLine("Area of Square ;{0}", 0.5 * b * h);
        }
    }
}