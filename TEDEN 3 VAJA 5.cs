
using System;

class Program
{
    static void Main()
    {
        int ocena;
        int vsota = 0;
        int steviloOcen = 0;

        while (true)
        {
            Console.Write("Vnesite oceno (5-10) ali -1 za konec: ");
            string? vnos = Console.ReadLine();

            
            if (!int.TryParse(vnos, out ocena))
            {
                Console.WriteLine("Napaka! Vnesite celo stevilo.");
                continue;
            }

            
            if (ocena == -1)
            {
                break;
            }

            
            if (ocena < 5 || ocena > 10)
            {
                Console.WriteLine("Napaka! Ocena mora biti med 5 in 10.");
                continue;
            }

           
            vsota += ocena;
            steviloOcen++;
        }

       
        if (steviloOcen > 0)
        {
            double povprecje = (double)vsota / steviloOcen;
            Console.WriteLine($"Povprecna ocena je: {povprecje:F2}");
        }
        else
        {
            Console.WriteLine("Niste vnesli nobene ocene.");
        }
    }
}
