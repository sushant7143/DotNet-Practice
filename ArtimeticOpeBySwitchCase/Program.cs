namespace ArtimeticOpeBySwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            double a ,b ,c;
            Console.WriteLine("\n 1 : Addition \n 2 : Subtraction \n 3 : Multiplication \n 4 : Division ");
            Console.Write("Enter your choice : ");
            ch = int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1: 
                    Console.Write("Enter the first number :");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number :");
                    b = double.Parse(Console.ReadLine());
                    c = a + b;
                    Console.WriteLine("Addition is : " + c);
                    break;

                case 2:
                    Console.Write("Enter the first number :");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number :");
                    b = double.Parse(Console.ReadLine());
                    c = a - b;
                    Console.WriteLine("Subtraction is : " + c);
                    break;

                case 3:
                    Console.Write("Enter the first number :");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number :");
                    b = double.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Multiplication is : " + c);
                    break;

                case 4:
                    Console.Write("Enter the first number :");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number :");
                    b = double.Parse(Console.ReadLine());
                    c = a / b;
                    Console.WriteLine("Division is : " + c);
                    break;

                default:
                    Console.WriteLine("You Enter wrong choich");
                    break;

            }
            Console.ReadKey();
        }
    }
}
