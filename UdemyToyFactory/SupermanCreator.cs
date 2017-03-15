using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class SupermanCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new Superman();
        }
    }
}
