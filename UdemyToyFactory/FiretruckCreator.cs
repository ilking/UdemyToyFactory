using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class FiretruckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new FireTruck();
        }
    }
}
