using System.ComponentModel;
using System.Drawing;
using System.Xml.Linq;
using System.Linq;

namespace Lecture4_HW_4._1_Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program in C# Sharp to display a number in reverse order.
            //Test Data:
            //            Input a number: 12345
            // :
            //The number in reverse order is : 54321
            //----------------------------------------


            Console.WriteLine("Reversing int: ");

            var number = 12345;
            Console.WriteLine(ReverseNumber(number));

            Console.WriteLine("\n");



            //Write a C# Sharp program to display an alphabet pattern like A with an asterisk.Reversed string is:Display the pattern like 'A' with an asterisk:
            //----------------------------------------

            Console.WriteLine("Printing pseudographics: ");

            var printer = new PseudoGraphicsAlphabet();

            printer.PrintStringInPseudo("cAt");
            Console.WriteLine("\n");



            //Write a C# Sharp program to find the second largest element in an array.
            //Test Data :
            //Input the size of array: 5
            //Input 5 elements in the array :
            //element - 0 : 2
            //element - 1 : 9
            //element - 2 : 1
            //element - 3 : 4
            //element - 4 : 6
            // :
            //The Second largest element in the array is: 6
            //------------------------------------------------------

            Console.WriteLine("Finding the second largest number in array: ");

            var array = new int[] { 2, 9, 1, 4, 6 };
            Console.WriteLine(FindSecondLargestNumber(array));

            Console.WriteLine("\n");



            //Write a C# Sharp program to check whether a triangle can be formed by the given angles value.
            //Test Data:
            //            40 55 65
            // :
            //The triangle is not valid.

            Console.WriteLine("Checking the correctness of triangle: \n");
            Console.WriteLine(IsCorrectTriangle(40, 55, 65));


        }

        public static bool IsCorrectTriangle(int a, int b, int c)
        {
            if (a + b + c == 180)
            {
                return true;
            }
            else
                return false;
        }

        public static int ReverseNumber(int number)
        {
            var str = number.ToString().Reverse().ToArray();
            return int.Parse(str);
        }

        public static int FindSecondLargestNumber(int[] array)
        {
            array = array.OrderByDescending(x => x).ToArray();
            return array[1];
        }
    }
}
