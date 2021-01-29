using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    class ConditionalExpressions
    {
        public void Tryouts()
        {
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;

            int? x = condition ? 12 : null;

            IEnumerable<int> xs = x is null ? new List<int>() { 0, 1 } : new int[] { 2, 3 };
        }
    }
}
