namespace ConsoleApp5
{
    internal class Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("this is the main hospital");
        }
    }
    class Apollo : Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("this is the Apollo hospital");
        }

    }
    class Workhardt : Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("this is the workhardt hospital");
        }
    }
    class Gokul_Superspeciality : Hospital
    {
        public void hospitalDetails()
        {
            Console.WriteLine("this is the Gokul_Superspeciality hospital");
        }
    }
}