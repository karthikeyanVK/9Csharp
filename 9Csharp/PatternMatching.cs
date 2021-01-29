﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Csharp
{
    static class PatternMatching
    {

        public static bool IsLetter(this char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsLetterOrSeparator(this char c) =>  c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
    }
}
