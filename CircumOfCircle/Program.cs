namespace CircumOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, s;
            Console.Write("Enter the radius of circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            s = (2 * 3.14f) * r;
            Console.WriteLine("Circumfernce of circle : " + s);
            Console.ReadKey();
        }

    }
}
