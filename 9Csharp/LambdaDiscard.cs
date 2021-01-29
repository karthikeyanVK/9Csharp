using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    class LambdaDiscard
    {
        Func<int, int, int> constant = (_, _) => 42;
    }
}
