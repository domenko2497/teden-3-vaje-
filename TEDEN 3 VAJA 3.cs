namespace BUSCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Limit = 40;
            int People = 0;
            char Key;
            Console.WriteLine("Dobrodosli na avtobusu");
            while (People <= Limit)
            {
                Key = Console.ReadKey(true).KeyChar;
                switch (Key)
                {
                    case '+':
                        if (People >= Limit)
                        {
                            Console.WriteLine("ni več placa");
                        }
                        else if (People == 0 || People <= Limit)
                        {
                            People++;
                            Console.WriteLine($" Ljudje na avtobusu: {People}");

                        }
                        break;

                    case '-':
                        if (People <= 0)
                        {
                            Console.WriteLine("še je plac");
                        }
                        else if (People >= 0)
                        {
                            People--;
                            Console.WriteLine($" Ljudje na avtobusu: {People}");
                        }
                        break;
                }

            }




        }
    }
}
