using Demo.CSharp.Models;

namespace Demo.CSharp
{
    class Polymorphism
    {
        public static Kangaroo DowncastError()
        {
            Bear bear = new Bear();
            Animal @base = bear;

            // Runtime error because @base is a reference to a Bear type
            return (Kangaroo) @base;
        }

        public static void DifferenceBetweenNewAndOverride()
        {
            Kangaroo k = new Kangaroo();
            Animal k2 = k;
            int returns2 = k2.Legs();

            Bear b = new Bear();
            Animal b2 = b;
            int returns10 = b2.Legs(); // Calls Animal.Legs() instead of Kangaroo.Legs()
        }

        public class SealedOverrider : Animal
        {
            public sealed override int Legs()
            {
                return 20;
            }

            // Can't seal a hidden
            // public sealed hidden int Legs() 
        }
    }
}
