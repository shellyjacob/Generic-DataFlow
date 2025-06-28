using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DataFlow<T> : IDataFlow<T>  where T : class
    {
        private List<IBlock<T>> _blocksList = new List<IBlock<T>>();

        public T RunFlow(T input)
        {
            foreach (IBlock<T> block in _blocksList)
            {
                input = block.Process(input);
            }

            return input;
        }

        public void AddBlock(IBlock<T> block)
        {
            _blocksList.Add(block);
        }
    }
}
