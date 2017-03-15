using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    abstract class Toy
    {
        public abstract int GetPowderQuantity();
        public abstract TimeSpan GetHeatingTime();
        public abstract ConsoleColor GetColor();
    }
}
