// TODO: Learn, too confusing
using Demo.CSharp.Models;
using System;
using System.Collections.Generic;

namespace Demo.CSharp
{
    /*
     *  Covariance enables you to pass a derived type where a base type is expected.
     */
    class Covariance
    {
        public static void FeedAnimal(Animal p) { }

        public static void FeedBear(Bear p) { }

        public static void Instatiating()
        {
            // A base class can hold a derived class ...
            Animal b = new Bear();

            // but a derived class cannot hold a base class.
            //Bear d1 = new Animal();
        }

        public static void CovarianceExample()
        {
            Animal animal = new Animal();
            Bear bear = new Bear();

            // can use derived type where base is expected
            FeedAnimal(bear);

            // can't use base type where derived is expected
            // FeedBear(animal); - compiler error

            // requires an explicit downcast
            FeedBear((Bear)animal);
        }
    }

    // see http://tomasp.net/blog/variance-explained.aspx/
    public class Contravariance
    {
        public void ContravarianceExample()
        {
            IComparer<Animal> compareAnimals = new AnimalSizeComparator();
            CompareCats(compareAnimals);
        }

        // Contravariance works the other way than covariance.
        // Usually you can't require a derived type then use a base type
        // but thanks to contravariance you can.
        // Below, this is achieved because IComparer uses the 'in' keyword.
        void CompareCats(IComparer<Bear> comparer)
        {
            var bear1 = new Bear();
            var bear2 = new Bear();
            if (comparer.Compare(bear2, bear1) > 0)
                Console.WriteLine("Bear 2 wins!");
        }
    }

    // 'out' used for contravariant return type
    // 'in' used for contravariant input parameter
    interface IVariant<out R, in A>
    {
        R contravariantReturnType();
        void contravariantInputParam(A a);
    };

    class AnimalSizeComparator : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            return x.GetHashCode() > y.GetHashCode() ? 1 : 0;
        }
    }
}
