using System;
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}  {1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}  {1}", int.MinValue, int.MaxValue);
            Double i = Double.MaxValue;
            Console.WriteLine(i);
            byte b = (byte)i;
            Console.WriteLine(b);
            string s = "1.5";
            decimal j = Convert.ToDecimal(s);
            Console.WriteLine(j);



        }
    }
}
