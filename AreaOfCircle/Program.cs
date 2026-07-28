namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, p = 3.14f, s;
            Console.Write("Entert the Radius of circle :");
            r = Convert.ToDouble(Console.ReadLine());
            s = p * r * r;
            Console.WriteLine("Area of Circle : " + s);
            Console.ReadKey();
        }
    }
}
