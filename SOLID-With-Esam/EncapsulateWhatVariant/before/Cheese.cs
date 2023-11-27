using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateWhatVariant.before
{
    internal class Cheese:Pizaa
    {
        public override string Title => $"{nameof(Cheese)}";
        public override decimal Price => base.Price + 3;
    }
}
