using System;
using System.Collections.Generic;
using System.Text;

namespace EvidencePojisteni
{
    /// <summary>
    /// Reprezentuje jednoho pojištěného.
    /// </summary>
    internal class Pojisteny
    {
        /// <summary>
        /// Jméno pojištěného.
        /// </summary>
        public string Jmeno { get; set; }


        /// <summary>
        /// Příjmení pojištěného.
        /// </summary>
        public string Prijmeni { get; set; }


        /// <summary>
        /// Věk pojištěného.
        /// </summary>
        public int Vek { get; set; }


        /// <summary>
        /// Telefonní kontakt.
        /// </summary>
        public string Telefon { get; set; }


        /// <summary>
        /// Konstruktor vytvoří nového pojištěného.
        /// </summary>
        public Pojisteny(string jmeno, string prijmeni, int vek, string telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }


        /// <summary>
        /// Vrací textovou podobu pojištěného.
        /// </summary>
        public override string ToString()
        {
            return $"{Jmeno,-15} {Prijmeni,-15} {Vek,-5} {Telefon,-15}";
        }
    }
}