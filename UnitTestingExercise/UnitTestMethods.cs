using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {

        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        public int Subtract(int minuend, int subtrhend)
        {
           // throw new NotImplementedException();
            return minuend - subtrhend;
        }

        public int Multiply(int num1, int num2)
        {
            //throw new NotImplementedException();
            return num1 * num2;
        }


        public int Divide(int div1, int div2)
        {
           // throw new NotImplementedException();
            return div1 / div2;
        }


    }
}
