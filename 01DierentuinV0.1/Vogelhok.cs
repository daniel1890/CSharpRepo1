using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin
{
    class Vogelhok
    {
        public List<Vogel> Vogels = new List<Vogel>();

        public void VoegVogelToe(Vogel vogel)
        {
            Vogels.Add(vogel);
        }

        public void PrintvogelsEigenschappen()
        {
            int vogelNummer = 1;
            foreach (Vogel vogel in Vogels)
            {
                Console.WriteLine("De vogelkooi bevat: ");
                Console.WriteLine("vogelnummer: " + vogelNummer);
                Console.WriteLine(vogel.Naam);
                Console.WriteLine("Aantal vleugels: " + vogel.AantalVleugels);
            }
        }
    }
}
