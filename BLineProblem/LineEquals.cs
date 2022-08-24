using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLineProblem
{
    internal class LineEquals
    {
        public double r1 = 0;
        public double r2 = 0;
        public double ans1;
        public double ans2;
        public double LineOne()
        {
            Console.WriteLine("Enter the coordinates of Line One");
            Console.WriteLine("Enter the value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y2, 2));
            Console.WriteLine("The Length Of Line one is: " + r1);
            ans1 = r1;
            return r1;
        }
        public double LineTwo()
        {
            Console.WriteLine("Enter the coordinates of Line Two");
            Console.WriteLine("Enter the value for X1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value for x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y2, 2));
            Console.WriteLine("The Length Of Line one is: " + r2);
            ans2 = r2;
            return r2;
        }
        public void LineCompare()
        {

        }
       
    }
}
