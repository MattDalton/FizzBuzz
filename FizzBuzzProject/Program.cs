using FizzBuzzProject;

class Program
{
    public static void Main(string[] args)
    {
        FizzBuzz FizzBuzz = new FizzBuzz(); 

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(FizzBuzz.GetOutput(i));
        }
    }
}