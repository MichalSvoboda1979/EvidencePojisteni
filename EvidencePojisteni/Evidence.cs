using System;
using System.Collections.Generic;
using System.Linq;

namespace EvidencePojisteni
{
    /// <summary>
    /// Spravuje seznam všech pojištěných osob.
    /// </summary>
    internal class Evidence
    {
        private List<Pojisteny> pojisteni;


        /// <summary>
        /// Vytvoří prázdnou evidenci.
        /// </summary>
        public Evidence()
        {
            pojisteni = new List<Pojisteny>();
        }


        /// <summary>
        /// Přidá nového pojištěného.
        /// </summary>
        public void PridejPojisteneho(Pojisteny osoba)
        {
            pojisteni.Add(osoba);
        }


        /// <summary>
        /// Vrátí všechny uložené pojištěné.
        /// </summary>
        public List<Pojisteny> VratVsechny()
        {
            return pojisteni;
        }


        /// <summary>
        /// Vyhledá pojištěného podle jména a příjmení.
        /// </summary>
        public List<Pojisteny> Vyhledej(string jmeno, string prijmeni)
        {
            List<Pojisteny> vysledky = new List<Pojisteny>();

            foreach (Pojisteny p in pojisteni)
            {
                if (p.Jmeno.ToLower() == jmeno.ToLower()
                    && p.Prijmeni.ToLower() == prijmeni.ToLower())
                {
                    vysledky.Add(p);
                }
            }

            return vysledky;
        }
    }
}