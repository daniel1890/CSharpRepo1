using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.interfaces
{
    internal interface IDierBasisPropsWritable
    {
        public int AantalLedematen { set; }
        public string Naam { set; }
    }
}