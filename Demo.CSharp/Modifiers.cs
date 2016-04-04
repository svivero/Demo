using System;

namespace Demo.CSharp
{
    // default is internal
    class Class
    {
        // default is private
        int y;

        protected void ProtectedMethod()
        {

        }
    }

    // default is internal
    interface Interface
    {
        // must be implemented as public
        void DefaultPublic();

        void DefaultSealed();

        void ExplicitlyImplemented();

        int Count { get; }
    }

    class DerivedClass : Class, Interface
    {
        public int Count => 1;

        // Interface method defaults to sealed, so if you req override then must mark as public
        public virtual void DefaultPublic()
        {
            throw new NotImplementedException();
        }

        public void DefaultSealed()
        {
            throw new NotImplementedException();
        }

        // 'public' not required
        // 'virtual' not possible
        // 'sealed' not possible
        void Interface.ExplicitlyImplemented()
        {

        }

        private void CallProtectedFromDerived()
        {
            ProtectedMethod();
        }

        private void CallProtectedFromInstance()
        {
            Class instance = new Class();

            // Can't see it, its protected
            // instance.Method();
        }
    }

    class DerivedFromDerivedClass : DerivedClass
    {
        public override void DefaultPublic()
        {
            base.DefaultPublic();
        }

        // Dosn't work, default is sealed
        // override DefaultSealed()
    }

    abstract class Abstract
    {
    }
}
