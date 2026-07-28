namespace PositiveNegative_MaxBetThree_LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check number is positive or Negative
            double a;
            Console.WriteLine("Enter the number for Check positive or Negative ");

            Console.Write("Enter the number : ");
            a = double.Parse(Console.ReadLine());
          
            if(a >= 0)
            {
                Console.WriteLine("Number is Positive ");
            }
            else
            {
                Console.WriteLine("Number is Negative ");
            }

            // Max between two numbers
            double x , y;
            Console.WriteLine();
            Console.WriteLine("Enter the number for Check Max between them ");
            Console.Write("Enter the first number : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            y = double.Parse(Console.ReadLine());
            if(x >= y)
            {
                Console.WriteLine(x + " is the max number ");
            }
            else
            {
                Console.WriteLine(y + " is the max number ");
            }

            // Check the Leap Year
            int z;
            Console.WriteLine();
            Console.WriteLine("Enter the number for check year leap or not ");
            Console.Write("Enter the year : ");
            z = int.Parse(Console.ReadLine());
            if (z % 4 == 0 )
            {
                Console.WriteLine(z + " This Year is Leap");
            }
            else
            {
                Console.WriteLine(z + " This Year is not Leap");
            }

            Console.ReadKey();


        }
    }
}
