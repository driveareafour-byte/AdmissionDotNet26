using System;
using System.Security.Cryptography.X509Certificates;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb();
            bulb.BulbSituation += Print;

            bulb.Off();


        }
        static void Print(bool situation)
        {
            if(situation == true)
            {
                Console.WriteLine("Light is ON");
            }
            else
            {
                Console.WriteLine("Light is Off");
            }
        }
    }
}
