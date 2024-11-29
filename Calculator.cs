using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment4
{
    public class Calculator<T> where T : IComparable, IConvertible
    {
        // Addition method
        public T Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        // Subtraction method
        public T Subtract(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        // Multiplication method
        public T Multiply(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }

        // Division method
        public T Divide(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;

            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return x / y;
        }
    }

   
  

}
