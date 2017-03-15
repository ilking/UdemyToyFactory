using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    class FireTruck : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(15);
        }

        public override int GetPowderQuantity()
        {
            return 104;
        }
    }
}
