using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitual_ModificadorSealedCSharp
{
    class ChildClass2
        : AnotherClass
    {
        public override sealed int Sum(int a, int b)
        {
            return base.Sum(a, b);
        }
    }
}
