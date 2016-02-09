using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CSharp
{
    public class Properties
    {
        // Equivalent to ReadOnly { get { return 1 + 10; } }
        public int ReadOnly => 1 + 10;

        // Automatic property 
        // CLR will compile this to methods: get_Automatic and set_Automatic
        public int Automatic { get; set; }

        // Set initial value to 1
        public int AutomaticAndInitialized { get; set; } = 1;

        // Indexers
        // CLR will compile this to methods: get_Item(int index) and set_Item(int index)
        private int[] array;
        public int this[int index]
        {
            get { return array[index]; } set { array[index] = value; }
        }

        // Constants
        // Evaluated at compile time
        // Different to static readonly because a constant can never change
        public const int Constant = 1;
    }
}
