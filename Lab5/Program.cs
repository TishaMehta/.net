namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Add(12, 6);
            c1.Add(13, 7,2);

            Class2 c2 = new Class2();
            c2.area(2);
            c2.area(3,5);

            Class3 c3 = new Class3();
            c3.area(4);
            c3.area(5,6);
            c3.area(2.3);

            Class4 c4 = new Class4();
            c4.calculateInterest();
            HDFC h = new HDFC();
            h.calculateInterest();
            SBI s = new SBI();
            s.calculateInterest();
            ICICI i = new ICICI();
            i.calculateInterest();

            Hospital hp = new Hospital();
            hp.hospitalDetails();
            Apollo a = new Apollo();
            a.hospitalDetails();
            Workhardt w = new Workhardt();
            w.hospitalDetails();
            Gokul_Superspeciality g = new Gokul_Superspeciality();
            g.hospitalDetails();

            Class5 c5 = new Class5();
            Class5.factorial f = new Class5.factorial(c5.fact);
            f(5);

            Class6 c6 = new Class6();
            Class6.TrafficDel t1 = new Class6.TrafficDel(c6.yellow);
            Class6.TrafficDel t2 = new Class6.TrafficDel(c6.green);
            Class6.TrafficDel t3 = new Class6.TrafficDel(c6.red);
            t1();
            t2();
            t3();

        }
    }
}
