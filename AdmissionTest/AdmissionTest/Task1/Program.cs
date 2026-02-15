using Task1;

//Console.WriteLine("Hello World");

namespace GetDoubleValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Age = { 21, 25, 30, 35, 40 };
            //int result = Age.Calculate(Age, x => x*2);
            int result = Age.Calculate(x => x * 2);
            int old = Age[Age.Length / 2];
            Console.WriteLine("Age was:" + old + "And Returned is:" + result);
        }
    }
}
