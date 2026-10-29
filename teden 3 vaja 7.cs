namespace _3teden_vaja_7
{
    internal class Program
    {


        /*Ne izpiši sodih števil do 10*/

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
