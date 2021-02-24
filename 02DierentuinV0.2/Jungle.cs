using Dierentuin.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    internal class Jungle
    {
        public List<Tijger> Tijgers = new List<Tijger>();

        public Tijger MaakTijger(string Naam, int AantalLedematen)
        {
            Tijger tijger = new Tijger();
            tijger.Naam = Naam;
            tijger.AantalLedematen = AantalLedematen;
            return tijger;
        }

        public void VoegTijgerToe(Tijger tijger)
        {
            Tijgers.Add(tijger);
        }

        public void PrintTijgerEigenschappen()
        {
            foreach (Tijger tijger in Tijgers)
            {
                Console.WriteLine("Naam van de tijger: " + tijger.Naam + ".");
                Console.WriteLine("De tijger heeft " + tijger.AantalLedematen + " aantal ledematen.");
            }
        }
    }
}