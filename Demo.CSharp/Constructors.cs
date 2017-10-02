using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CSharp
{
    public class Private
    {
        private int width;
        private int height;

        // Class cannot be initialized
        private Private()
        {
            this.width = 1;
            this.width = 2;
        }

        // Sample use case, control object creation via static method
        public static Private Create()
        {
            // Could be useful returning some kind of subclass e.g. CreateRectangle(), CreateSquare()
            return new Private();
        }

        // But we can call static methods
        public static int CalculateArea()
        {
            return -1;
        }
    }

    public class ExpressionParam
    {
        public static object StaticExpression { get { return new object(); } }

        public object NonStaticField = new object();

        // Can pass expressions
        public ExpressionParam() : this (ExpressionParam.StaticExpression) { }

        // Can't pass a field because instance has not been created yet, compile time error
        //public ExpressionParam() : this(NonStaticField) { }

        public ExpressionParam(object param1) { }
    }

    public class OptionalParam
    {
        private int field;
        public OptionalParam(int mandatory, int optional = 1) { field = optional;  }

        // Only the mandatory was passed
        // Note optional params are problematic if calling from a different assembly, 
        // e.g. adding another optional param WITHOUT rebuilding, the calling assembly will
        // get a runtime error 
        public static OptionalParam Create() { return new OptionalParam(1);  }
    }

    public class StaticConstructor
    {
        static StaticConstructor()
        {
            // executes once per type instead of once per instance
        }

        // Access modifiers like below result in compile time error
        // public static StaticConstructor() { }
    }

    public class OrderOfInitialization
    {
        private static int @static = 1;

        private int nonStatic = 3;

        static OrderOfInitialization()
        {
            @static = 2;
        }

        public OrderOfInitialization()
        {
            nonStatic = 4;
        }
    }

    public class Finalizer
    {
        // Execute before garbage collection
        // Shorthand for overriding Finalize()
        ~Finalizer() { }
    }
}
