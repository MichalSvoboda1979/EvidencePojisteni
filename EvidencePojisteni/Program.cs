using System;
using System.Collections.Generic;
using System.Text;
// Hlavní vstupní bod aplikace
// Spouští menu evidence pojištěných osob

namespace EvidencePojisteni
{
    /// <summary>
    /// Hlavní třída aplikace.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nastaví název okna konzolové aplikace
            Console.Title = "Evidence pojištěných";

            // Nastaví kódování konzole na UTF-8,
            // aby se správně zobrazovaly české znaky (ě, š, č, ř, ž...)
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;


            Menu menu = new Menu();

            menu.Start();
        }
    }
}