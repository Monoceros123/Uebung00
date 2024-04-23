using System;

namespace TemperatureCalculator
{
    class Program
    {
        public static void Temperatur()
        {
            float fahrenheit, celsius = 0;
            fahrenheit = (9f / 5f * celsius) + 32f;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit \n", celsius, fahrenheit);
            Console.WriteLine("Celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (9f / 5f * celsius) + 32f;
            Console.WriteLine("Fahrenheit: {0}\n", fahrenheit);
        }
    }
}