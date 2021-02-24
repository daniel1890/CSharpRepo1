using System;

namespace Dierentuin.classes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dierentuin D = new Dierentuin();
            D.JungleGebied.VoegTijgerToe(D.JungleGebied.MaakTijger("Simba", 4));
            D.JungleGebied.PrintTijgerEigenschappen();

            D.AquariumGebied.VoegVisToe(D.AquariumGebied.MaakVis("Nemo", 2));
            D.AquariumGebied.PrintVisEigenschappen();
        }
    }
}