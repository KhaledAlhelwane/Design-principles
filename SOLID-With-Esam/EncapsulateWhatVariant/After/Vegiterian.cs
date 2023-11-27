using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateWhatVariant.After
{
    internal class Vegiterian:Pizaa
    {
        public override string Title => $"{nameof(Vegiterian)}";
        public override decimal Price => base.Price +2;
    }
}
