using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayProcessor.LogicClasses
{
    internal class MatrixCreator
    {
        RandomNumberCreator _randomNumberCreator;

        int i; int j;
        public MatrixCreator(RandomNumberCreator randomNumberCreator)
        {
            _randomNumberCreator = randomNumberCreator;
        }

        public int[,] Create(int ArrayDimension)
        {
            int[,] someNumbers;

            someNumbers = new int[ArrayDimension, ArrayDimension];

            // int upperArrayDimension = ArrayDimension - 1;

            for (i = 0; i < ArrayDimension; i++) {

                for (j = 0; j < ArrayDimension; j++)
                {
                    someNumbers[i, j] = _randomNumberCreator.Create();
                }
            }

            // Console.WriteLine(someNumbers[0, 1] + " " + someNumbers[0, 0] + " " + someNumbers[0, tempArrayDimesnion]);

            return someNumbers;
        }
    }
}
