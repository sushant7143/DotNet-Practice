namespace MaxBetTwobyTernaryOpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a ,b , c;
            Console.Write("Enter the first number : ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            b = double.Parse(Console.ReadLine());

            c = a > b ? a : b ;
            Console.WriteLine(c + " is max");
            Console.ReadKey();
        }
    }
}
