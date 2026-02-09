using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudandoTernarios.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int number) => number % 2 == 0;
    }
}