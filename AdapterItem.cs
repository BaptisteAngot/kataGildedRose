using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class AdapterItem : Item, IItem
    {
        private Item item { get; set; }
    }
}
