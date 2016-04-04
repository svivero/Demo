/*
    ✓ CONSIDER defining a struct instead of a class if instances of the type are small and 
    commonly short-lived or are commonly embedded in other objects.

    X AVOID defining a struct UNLESS the type has all of the following characteristics:
    It logically represents a single value, similar to primitive types (int, double, etc.).
    It has an instance size under 16 bytes.
    It is immutable.
    It will not have to be boxed frequently.
*/
namespace Demo.CSharp
{
    public interface BaseInterface { }

    public class BaseClass {
        public virtual int BaseMethod() { return 1; }
    }

    struct StructBase { }

    // Can't derive from a struct or class
    // struct Struct : StructBase
    // struct Struct : BaseClass { }

    struct Struct : BaseInterface
    {
        private int x;
        private int y;

        // Can't use field initializer
        // private int y = 2;

        // Parameterless constructor not allowed
        // public Struct() {}

        public Struct(int x)
        {
            // Must assign all fields
            this.x = x; 
            this.y = 2;
        }

        public void Method() { }        
    }
}
