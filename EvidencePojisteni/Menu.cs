using System;
using System.Collections.Generic;
using System.Text;

namespace EvidencePojisteni
{
    /// <summary>
    /// Třída zajišťující ovládání programu pomocí menu.
    /// </summary>
    internal class Menu
    {
        private Evidence evidence;


        /// <summary>
        /// Konstruktor vytvoří novou evidenci.
        /// </summary>
        public Menu()
        {
            evidence = new Evidence();
        }


        /// <summary>
        /// Spustí hlavní smyčku programu.
        /// </summary>
        public void Start()
        {
            bool pokracovat = true;

            while (pokracovat)
            {
                Console.Clear();

                VypisHlavicku();

                Console.WriteLine("1 - Přidat pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");

                Console.WriteLine();

                string volba = ConsoleHelper.NactiText("Vyber možnost: ");

                Console.Clear();

                switch (volba)
                {
                    case "1":
                        PridejPojisteneho();
                        break;

                    case "2":
                        VypisPojistene();
                        break;

                    case "3":
                        VyhledejPojisteneho();
                        break;

                    case "4":
                        pokracovat = false;
                        break;

                    default:
                        Console.WriteLine("Neplatná volba.");
                        break;
                }


                // Pokud uživatel nezvolil konec programu,
                // čekáme na stisk klávesy a vrátíme se zpět do menu
                if (pokracovat)
                {
                    Console.WriteLine();
                    Console.WriteLine("Pokračujte stiskem libovolné klávesy...");
                    Console.ReadKey();
                }
            }


            Console.WriteLine();
            Console.WriteLine("Program ukončen.");
        }


        /// <summary>
        /// Přidání nového pojištěného.
        /// </summary>
        private void PridejPojisteneho()
        {
            Console.WriteLine("=== Přidání pojištěného ===");
            Console.WriteLine();


            string jmeno = ConsoleHelper.NactiText("Jméno: ");

            string prijmeni = ConsoleHelper.NactiText("Příjmení: ");

            int vek = ConsoleHelper.NactiCislo("Věk: ");

            string telefon = ConsoleHelper.NactiText("Telefon: ");


            Pojisteny pojisteny =
                new Pojisteny(jmeno, prijmeni, vek, telefon);


            evidence.PridejPojisteneho(pojisteny);


            Console.WriteLine();
            Console.WriteLine("Pojištěný byl úspěšně přidán.");
        }



        /// <summary>
        /// Vypíše všechny pojištěné osoby.
        /// </summary>
        private void VypisPojistene()
        {
            Console.WriteLine("=== Seznam pojištěných ===");
            Console.WriteLine();


            var seznam = evidence.VratVsechny();


            if (seznam.Count == 0)
            {
                Console.WriteLine("Evidence je prázdná.");
                return;
            }


            
           
            Console.WriteLine(
                $"{"Jméno",-15} {"Příjmení",-15} {"Věk",-5} {"Telefon",-15}");

         
            Console.WriteLine(new string('-', 55));


            foreach (Pojisteny p in seznam)
            {
                Console.WriteLine(p);
            }
        }



        /// <summary>
        /// Vyhledá pojištěného.
        /// </summary>
        private void VyhledejPojisteneho()
        {
            Console.WriteLine("=== Vyhledávání ===");
            Console.WriteLine();


            string jmeno =
                ConsoleHelper.NactiText("Jméno: ");

            string prijmeni =
                ConsoleHelper.NactiText("Příjmení: ");


            List<Pojisteny> vysledky =
                evidence.Vyhledej(jmeno, prijmeni);



            if (vysledky.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nikdo nebyl nalezen.");
                return;
            }


            Console.WriteLine();

            foreach (Pojisteny p in vysledky)
            {
                Console.WriteLine(p);
            }
        }



        /// <summary>
        /// Vypíše hlavičku programu.
        /// </summary>
        private void VypisHlavicku()
        {
            Console.WriteLine("===============================");
            Console.WriteLine("       EVIDENCE POJIŠTĚNÝCH");
            Console.WriteLine("===============================");
            Console.WriteLine();
        }
    }
}