namespace ConsoleApp4
{
    internal class Class10
    {
        public void invert(string s)
        {
            string str = "";
            var arr = s.ToCharArray();
            foreach(char c in arr)
            {
                if (char.IsUpper(c))
                {
                    str += c.ToString().ToLower();
                }
                else
                {
                    str += c.ToString().ToUpper();
                }
            }
            Console.WriteLine(str);
        }
    }
}