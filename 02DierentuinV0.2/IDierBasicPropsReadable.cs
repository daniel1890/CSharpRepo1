using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.interfaces
{
    internal interface IDierBasicPropsReadable
    {
        public int AantalLedematen { get; }
        public string Naam { get; }
    }
}