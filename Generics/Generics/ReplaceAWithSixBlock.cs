using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ReplaceAWithSixBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return input.Replace("A", "6");
        }
    }
}
