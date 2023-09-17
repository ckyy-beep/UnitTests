using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class WorldsDumbestFunction
    {
        public string ReturnsPokemonIfZero(int num)
        {
            if (num == 0) 
            {
                return "PIKACHU!";
            }
            else
            {
                return "Squirtle!";
            }
        }
    }
}
