using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.classes
{
    internal class Aquarium
    {
        public List<Vis> Vissen = new List<Vis>();

        public Vis MaakVis(string Naam, int AantalLedematen)
        {
            Vis vis = new Vis();
            vis.Naam = Naam;
            vis.AantalLedematen = AantalLedematen;
            return vis;
        }

        public void VoegVisToe(Vis Vis)
        {
            Vissen.Add(Vis);
        }

        public void PrintVisEigenschappen()
        {
            foreach (Vis vis in Vissen)
            {
                Console.WriteLine("Naam van de vis: " + vis.Naam + ".");
                Console.WriteLine("De vis heeft " + vis.AantalLedematen + " aantal ledematen.");
            }
        }
    }
}