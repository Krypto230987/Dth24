using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm24
{
    internal class GenericArray<T>
    {
        private T[] array;

        public GenericArray(T[] array)
        {
            this.array = array;
        }

        public void Sort()
        {
            Array.Sort(array);
        }

        public void Reverse()
        {
            Array.Reverse(array);
        }
    }
}
