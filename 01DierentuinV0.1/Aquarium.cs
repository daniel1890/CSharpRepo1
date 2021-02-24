using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Aquarium
    {
        public List<Vis> Vissen = new List<Vis>();

        public void VoegVisToe(Vis vis)
        {
            Vissen.Add(vis);
        }

        public void PrintVissenEigenschappen()
        {
            int visNummer = 1;
            foreach (Vis vis in Vissen)
            {
                Console.WriteLine("Het aquarium bevat: ");
                Console.WriteLine("visnummer: " + visNummer);
                Console.WriteLine(vis.Naam);
                Console.WriteLine("Aantal vinnen: " + vis.AantalVinnen);
            }
        }
    }
}
