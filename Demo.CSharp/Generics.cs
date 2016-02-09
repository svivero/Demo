using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Demo.CSharp.Models;

namespace Demo.CSharp
{
    /*
        Whereas inheritance expresses reusability with a base type, generics express reusability with a “template” that contains “placeholder” types. 
        Generics, when compared to inheritance, can increase type safety and reduce casting and boxing.
    */

    class Stack<T> 
        // Sample Constraints
        // where T : struct, IStack
        // where U : StackBase, new () 
    {
        int position;
        T[] data = new T[100];
        public void Push(T obj) => data[position ++] = obj; 
        public T Pop() => data[--position];
    }

    class Test {
        static void Wash(Stack<Animal> a) { }
        static void Wash(Animal a) { }
        static void WashWithAnimalContraint<T>(Stack<T> a) where T : Animal { }

        static void ExecuteWash()
        {
            Stack<Bear> bears = new Stack<Bear>();
            Animal a = new Animal();

            Wash(a);

            // error because co-variance is not automatic
            //Wash(bears);  

            WashWithAnimalContraint<Bear>(bears);
        }
    }
   
}
