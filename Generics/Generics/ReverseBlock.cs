using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ReverseBlock : IBlock<string>
    {
        public string Process(string input)
        {
            return String.Join("", input.ToArray().Reverse());
        }
    }
}