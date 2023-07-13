internal class Program
{
    private static void Main(string[] args)
    {


        string input = Console.ReadLine();

        string[] coefficient = input.Split(' ');


        Int16 a = Convert.ToInt16(coefficient[0]);
        Int16 b = Convert.ToInt16(coefficient[1]);
        Int16 c = Convert.ToInt16(coefficient[2]);


        int discriminant = b * b - 4 * a * c;

        double root1 = 0;
        double root2 = 0;

        if (discriminant > 0)
        {
            double squareRoot = Math.Sqrt(discriminant);
            root1 = (-b + squareRoot) / (2 * a);
            root2 = (-b - squareRoot) / (2 * a);

        }

        Console.Write("{0} {1}", root1, root2);
         
    }
}
