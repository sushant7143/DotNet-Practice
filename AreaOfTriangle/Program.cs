namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h , b , s ;
            Console.Write("Entert the Base of circle :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entert the Height of circle :");
            h = Convert.ToDouble(Console.ReadLine());
            s = 0.5 * b * h ;
            Console.WriteLine("Area of Triangle : " + s);
            Console.ReadKey();
        }
    }
}
