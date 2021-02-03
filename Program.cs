using System;
using System.Linq;

namespace Nastyhacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string x1 = Console.ReadLine();
            int x = Convert.ToInt32(x1);
            //list<int> int_list = new List<int>;


            for (int i=0;i<x;i++)
            {
                string [] integers = (Console.ReadLine().Split(" "));
                
                
                    if (Convert.ToInt32(integers[1]) - Convert.ToInt32(integers[2]) > Convert.ToInt32(integers[0]))
                    {
                        Console.WriteLine("advertise");
                    }
                    else if (Convert.ToInt32(integers[1]) - Convert.ToInt32(integers[2]) == Convert.ToInt32(integers[0]))
                    {

                        Console.WriteLine("does not matter");
                    }

                    else {
                        Console.WriteLine("do not advertise");
                    }
                    


                


                
            }
        }
    }
}
