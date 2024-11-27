using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment4
{
    internal class Storage<T>
    {
        T value;

        public void SetValue(T value)
        {
            this.value = value; 
        }

        public T GetValue() { return this.value; }
    }
}
