using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrayProcessor.LogicClasses
{
    internal class RandomNumberCreator
    {

        int _upperNumberExclusiveLimit;

        int IntTheRandomNumber;

        private Random Rand = new Random();

        public RandomNumberCreator(){}
        
        public RandomNumberCreator(int upperNumberExclusiveLimit)
        {
            _upperNumberExclusiveLimit = upperNumberExclusiveLimit;
        }

        public int Create()
        {

            IntTheRandomNumber = Rand.Next(0, _upperNumberExclusiveLimit);

            return IntTheRandomNumber;
        }

    }
}
