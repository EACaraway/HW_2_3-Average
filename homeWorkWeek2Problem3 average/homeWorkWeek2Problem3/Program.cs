using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek2Problem3
{                                                                           //Evan Caraway, Srinivas Reddy Doma, Kipack Jeong
   
    class Program
    {
        public static void WriteAverage(int num1, int num2)                 //method named WriteAverage for taking the average of two numbers.
        {
            Console.WriteLine($"The average of {num1} and {num2} = {(num1 + num2)/2.0}");
        }
        static void Main(string[] args)
        {
            WriteAverage(2, 7);                                             // calling the method WriteAverage from the main method.
        }
        
    }
}
