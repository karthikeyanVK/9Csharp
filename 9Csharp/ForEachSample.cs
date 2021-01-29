using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    class ForEachSample
    {
        public void Tryouts()
        {


            Span<int> numbers = new int[] { 3, 14, 15, 92, 6 };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

    }
}
