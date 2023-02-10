using System;

namespace uppgift6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta");
            Console.WriteLine("skriv ner nummer som den val");
            int svar = int.Parse(Console.ReadLine());

            switch(svar)
            {
                case 1:
                    {
                        Console.WriteLine("Skriv ner den två var en i sin rad");
                        int addition1 = int.Parse(Console.ReadLine());
                        int addition2 = int.Parse(Console.ReadLine());
                        int addition3 = int.Parse(Console.ReadLine());
                        tal(addition1, addition2, addition3);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Skriv ner den två var en i sin rad");
                        int störst1 = int.Parse(Console.ReadLine());
                        int störst2 = int.Parse(Console.ReadLine());
                        Störst(störst1, störst2);
                    }
                    break;
                case 3:
                    {
                        avsluta();
                    }
                    break;
            }
        }
        static void tal(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            Console.WriteLine("Den summa är" + summa + ".");
        }
        static void Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                Console.WriteLine("Den största talen är" + tal1 + ".");
            }
            else if (tal1 < tal2)
            {
                Console.WriteLine("Den största talen är" + tal2 + ".");
            }
            else if (tal1 == tal2)
            {
                Console.WriteLine("De är lika stora");
            }
        }

        static void avsluta()
        {
            return;
        }
            
    }
}