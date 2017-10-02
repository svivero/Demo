namespace Demo.CSharp
{
    /*
     * .NET provides a unified type system. All types including value types derive from the type 
     *  object. 

     * Converting a value type to reference type is called Boxing. 
     * Unboxing is the opposite operation and is an explicit operation.        
     */
    class BoxingAndUnboxing
    {
        public void Example1()
        {
            int i = 1;
            object o = i;   // boxing
            int j = (int)o;	// unboxing
        }
    }
}
