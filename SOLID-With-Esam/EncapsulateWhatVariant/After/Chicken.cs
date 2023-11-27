using EncapsulateWhatVariant.before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulateWhatVariant.After
{
    internal class Chicken:Pizaa
    {
        public override string Title => $"{nameof(Chicken)}";
        public override decimal Price => base.Price + 3;
    }
}
