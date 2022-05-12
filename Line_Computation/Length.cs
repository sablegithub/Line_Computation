using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Computation
{
    public class Length
    {
        public void calculatinglength()
        {
            Console.Write("Enter a x1:");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a y1:");
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a x2:");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a y2:");
            int y2=Convert.ToInt32(Console.ReadLine());

        double  length1 =x2 - x1;
        double length2 =y2 - y1;
         double   LengthofLine = Math.Sqrt(length1) + Math.Sqrt(length2);
            Console.WriteLine("Length of line " +   LengthofLine);

            if (length1 < length2)
            {
                Console.WriteLine("Lenght 1 greter than length 2");
            }

            else
            {
                Console.WriteLine("Length 2 is greter than  length 1");
            }

                 
        }
    }
}
