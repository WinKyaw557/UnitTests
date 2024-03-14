using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        public static void WorldsDumbestFunction_ReturnsPekachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Go get your variable, whatever you nee, you class, go get function
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                //Act - Execute the finction
                string result = worldsDumbest.ReturnsPikachuIfZero(num);


                //Assert - whatever returnid it is what you want
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldsDumbestFunction.ReturnsPikachuIfZero_RetunsString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldsDumbestFunction.ReturnsPikachuIfZero_RetunsString");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
