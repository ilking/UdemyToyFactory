using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class Duck : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Yellow;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(10);
        }

        public override int GetPowderQuantity()
        {
            return 75;
        }
    }
}
