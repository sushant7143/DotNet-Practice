namespace AverageOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c , t , d ;

            Console.Write("Enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number : ");
            c = Convert.ToInt32(Console.ReadLine());

            t = a + b + c ;

            d = t / 3 ;

            Console.WriteLine("Averege of three numbers : " + d );

            Console.ReadKey();
        }
    }
}
