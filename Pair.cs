using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment4
{
    internal class Pair<T1,T2>
    {
        T1 First;
        T2 Second;


        public void PrintPair()
        {
            Console.WriteLine($"First: {First} Second: {Second}");
        }
    }
}
