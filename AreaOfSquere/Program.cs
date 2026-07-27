namespace AreaOfSquere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s , l;
            Console.Write("Enter the side length :");
            s = Convert.ToDouble(Console.ReadLine());
            l = s * s;
            Console.WriteLine("Area of Triangle : " + l);
            Console.ReadKey();
        }
    }
}
