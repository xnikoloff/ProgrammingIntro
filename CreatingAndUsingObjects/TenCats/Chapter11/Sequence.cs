using System;
using System.Collections.Generic;
using System.Text;

namespace TenCats.Chapter11
{
    class Sequence
    {
        //static field
        private static int currentValue;

        //intentionally deny instantioation of this class 
        private Sequence()
        {

        }

        //static method for taking the next value
        public static int GetNextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}
