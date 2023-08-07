namespace ConsoleApp5
{
    public class Class4
    {
        public double p, r, n;
        public Class4()

        {
            p = 1; r = 2; n = 3;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst : {0}", (p * r * n) / 100);
        }
    }
    public class HDFC : Class4
    {
        public HDFC()
        {
            p = 2; r = 3; n = 4;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst : {0}", (p * r * n) / 100);
        }
    }
    public class SBI : Class4
    {
        public SBI()
        {
            p = 3; r = 3; n = 2;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst : {0}", (p * r * n) / 100);
        }
    }
    public class ICICI : Class4
    {
        public ICICI()
        {
            p = 3; r = 2; n = 2;
        }
        public void calculateInterest()
        {
            Console.WriteLine("Interst : {0}", (p * r * n) / 100);
        }
    }
    }