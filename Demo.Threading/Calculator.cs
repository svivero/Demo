using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Threading
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int AddAsync(int a, int b)
        {
            Task<int> t = new Task<int>(() => this.Add(a, b));
            return t.Result;
        }
    }
}
