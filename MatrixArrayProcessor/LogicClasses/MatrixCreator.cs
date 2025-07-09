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
            int[,] theMatrix;

            theMatrix = new int[ArrayDimension, ArrayDimension];

            for (i = 0; i < ArrayDimension; i++) {

                for (j = 0; j < ArrayDimension; j++)
                {
                    theMatrix[i, j] = _randomNumberCreator.Create();
                }
            }

            return theMatrix;
        }
    }
}
