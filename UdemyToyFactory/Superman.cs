using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class Superman : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Blue;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(5);
        }

        public override int GetPowderQuantity()
        {
            return 20;
        }
    }
}
