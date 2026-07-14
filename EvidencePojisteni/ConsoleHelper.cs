using System;
using System.Collections.Generic;
using System.Text;

namespace EvidencePojisteni
{
    /// <summary>
    /// Pomocné metody pro práci s konzolí.
    /// </summary>
    internal static class ConsoleHelper
    {

        /// <summary>
        /// Načte neprázdný text.
        /// </summary>
        public static string NactiText(string zprava)
        {
            string hodnota;

            do
            {
                Console.Write(zprava);
                hodnota = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(hodnota))
                {
                    Console.WriteLine("Hodnota nesmí být prázdná.");
                }

            } while (string.IsNullOrWhiteSpace(hodnota));


            return hodnota;
        }



        /// <summary>
        /// Načte číslo od uživatele.
        /// </summary>
        public static int NactiCislo(string zprava)
        {
            int cislo;

            while (true)
            {
                Console.Write(zprava);

                if (int.TryParse(Console.ReadLine(), out cislo))
                {
                    return cislo;
                }

                Console.WriteLine("Zadejte platné číslo.");
            }
        }
    }
}
