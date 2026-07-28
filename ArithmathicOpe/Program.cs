namespace ArithmathicOpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // + , - , * , / , %

            int a, b, c ,d ,e ,f ,j ;
            Console.Write("Enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Addition of two numbers " + c);

            d = a - b;
            Console.WriteLine("Subtraction of two numbers " + d);

            e = a * b;
            Console.WriteLine("Multiplication of two numbers " + e);

            f = a / b;
            Console.WriteLine("Division of two numbers " + f);

            j = a % b;
            Console.WriteLine("Modulus of two numbers " + j);

        }
    }
}
