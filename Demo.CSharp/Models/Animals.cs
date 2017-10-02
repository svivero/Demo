using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CSharp.Models
{
    public class Animal
    {
        public virtual int Legs()
        {
            return 10;
        }
    }

    public class Bear : Animal
    {
        // 'new' is used to hide
        public new int Legs()
        {
            return 4;
        }
    }

    public class Kangaroo : Animal
    {
        public override int Legs()
        {
            return 2;
        }
    }
}
