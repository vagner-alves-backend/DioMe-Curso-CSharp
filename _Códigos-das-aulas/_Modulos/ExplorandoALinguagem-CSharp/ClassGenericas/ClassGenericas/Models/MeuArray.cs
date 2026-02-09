using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassGenericas.Models
{
    public class MeuArray<Type>
    {
        private readonly int _contador = 0;
        private readonly Type[] _array = new Type[10];

        public void AddNewElement(Type element)
        {
            if (_contador + 1 <= 10)
            {
                _array[_contador] = element;
            } else
            {
                Console.WriteLine("O array cheio.");
            }
        }

        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
    }
}