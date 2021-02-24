using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Jungle
    {
        public List<Tijger> Tijgers = new List<Tijger>();

        public void VoegTijgerToe(Tijger tijger)
        {
            Tijgers.Add(tijger);
        }

        public void PrintTijgersEigenschappen()
        {
            int tijgerNummer = 1;
            foreach (Tijger tijger in Tijgers)
            {
                Console.WriteLine("De Jungle bevat: ");
                Console.WriteLine("Tijgernummer: " + tijgerNummer);
                Console.WriteLine(tijger.Naam);
                Console.WriteLine("Aantal poten: " + tijger.AantalPoten);
            }
        }
    }
}
