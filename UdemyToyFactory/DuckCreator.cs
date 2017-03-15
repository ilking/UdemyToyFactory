﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class DuckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new Duck();
        }
    }
}
