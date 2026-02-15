using System;
using System.Security.Cryptography.X509Certificates;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulb bulb = new Bulb();
            bulb.BulbSituationON += Print;
            bulb.BulbSituationOFF += Print;

            bulb.Off();
            bulb.On();

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
