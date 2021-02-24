using Dierentuin.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dierentuin.classes
{
    internal abstract class Dier : interfaces.IDierBasisPropsWritable, interfaces.IDierBasicPropsReadable
    {
        public int AantalLedematen { get; set; }
        public string Naam { get; set; }
    }
}