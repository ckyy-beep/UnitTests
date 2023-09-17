using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTest
    {
        //Naming Convention - ClassName_MethodName_ExpectedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, go get function
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute this function
                string result = worldsDumbest.ReturnsPokemonIfZero(num);

                //Assert - whatever is returned is it what you want.
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction.ReturnsPikachuIfZero.ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsPikachuIfZero.ReturnsString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
