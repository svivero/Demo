namespace Demo.CSharp
{
    public class Derived1 : BaseClass { }

    public class Derived2 : BaseClass { }

    public class Hider : BaseClass
    {
        public new int BaseMethod()
        {
            return 2;
        }
    }

    public class Overrider : BaseClass
    {
        public override int BaseMethod()
        {
            return 3;
        }
    }

    class Polymorphism
    {
        public static void WriteBase(BaseClass p) {}

        public static void WriteDerived(Derived1 p) {}

        public static void Instatiating()
        {
            // can upcast right to left
            BaseClass b = new Derived1();

            // can't downcast right to left
            //Derived1 d1 = new BaseClass();
        }

        public static void Invoking()
        {
            BaseClass b = new BaseClass();
            Derived1 d = new Derived1();

            // can upcast right to left
            WriteBase(d);

            // can't downcast right to left
            //WriteDerived(b);

            // requires an explicit downcast
            WriteDerived((Derived1)b);
        }

        public static Derived2 DowncastError()
        {
            Derived1 derived1 = new Derived1();
            BaseClass @base = derived1;

            // Runtime error because @base is a reference to a Derived1 type
            return (Derived2) @base;
        }

        public static void DifferenceBetweenNewAndOverride()
        {
            Overrider over = new Overrider();
            BaseClass b1 = over;
            int returns3 = b1.BaseMethod();

            Hider hider = new Hider();
            BaseClass b2 = hider;
            int returns1 = hider.BaseMethod(); // Calls BaseClass.BaseMethod() instead of Hider.BaseMethod()
        }

        public class SealedOverrider : BaseClass
        {
            public sealed override int BaseMethod()
            {
                return 4;
            }

            // Can't seal a hidden
            // public sealed hidden int BaseMethod() 
        }
    }
}
