using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Math(string[] args)
        {
            // int total= 5 + 10;
            // int otherTotal = 12 +22;
            // int combined = total + otherTotal;
            // Console.WriteLine(combined);
            // Console.ReadLine():

            // int difference = 10 - 5;
            // Console.WriteLine("Ten minus Five = " + difference.ToString());
            // Console.ReadLine();
            
            // int product = 10 * 5;
            // Console.WriteLine(product);
            // Console.ReadLine();

            // double quotient = 100.0 / 17.0;
            // Console.WriteLine(quotient);
            // Console.ReadLine();

            // int remainder = 11 % 2;
            // Console.WriteLine(remainder);
            // Console.ReadLine();

            // bool truOrFalse = 12 > 5;
            // Console.WriteLine(truOrFalse.ToString());
            // Console.ReadLine();

            int roomTempurature = 70;
            int currentTempurature = 70;

            // bool isWarm = currentTempurature <= roomTempurature;
            bool isWarm = currentTempurature != roomTempurature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}