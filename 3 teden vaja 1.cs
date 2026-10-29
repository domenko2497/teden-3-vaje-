using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" vnesi temperaturo:");
        string temperatura = Console.ReadLine();    

        if(int.TryParse(temperatura, out int temp))
        {
            if (temp <= 15)
            {
                Console.WriteLine("Mrzlo je.");
            }
            else if (temp <= 28 && temp > 15)
            {
                Console.WriteLine("V redu je temperatura.");
            }
            else if (temp > 28)
            {
                Console.WriteLine("Vroče za znort.");
            }
        }
        else
        {
            Console.WriteLine(" temperatura ni pravilno vnesena. Vnesi celo število.");
        }
    }
}