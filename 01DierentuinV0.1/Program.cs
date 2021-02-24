using System;

namespace Dierentuin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Dierentuin Dierentuin = new Dierentuin();

            // Voeg een vogel object toe aan de dierentuin.
            Vogel vogel = new Vogel
            {
                Naam = "Henk",
                AantalVleugels = 2
            };
            Dierentuin.Vogelhok.VoegVogelToe(vogel);

            // Voeg een tijger object toe aan de dierentuin
            var tijger = new Tijger
            {
                Naam = "Piet",
                AantalPoten = 4
            };
            Dierentuin.Jungle.VoegTijgerToe(tijger);

            // Voeg een vis object toe aan de dierentuin
            var vis = new Vis
            {
                Naam = "Klaas",
                AantalVinnen = 2
            };
            Dierentuin.Aquarium.VoegVisToe(vis);

            Dierentuin.Jungle.PrintTijgersEigenschappen();
            Dierentuin.Aquarium.PrintVissenEigenschappen();
            Dierentuin.Vogelhok.PrintvogelsEigenschappen();
        }
    }
}