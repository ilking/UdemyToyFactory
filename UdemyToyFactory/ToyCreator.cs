using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyToyFactory
{
    /// <summary>
    /// The abstract toy creator factory class.
    /// </summary>
    abstract class ToyCreator
    {
        
        /// <summary>
        /// Abstract factory method to create a new toy.
        /// </summary>
        /// <returns>The newly created toy.</returns>
        protected abstract Toy CreateToy();

        /// <summary>
        /// Make a new toy.
        /// </summary>
        public void MakeToy()
        {
            ConsoleColor current = Console.ForegroundColor;
            Toy toy = CreateToy();
            Console.ForegroundColor = toy.GetColor();
            int grams = toy.GetPowderQuantity();
            PreparePowder(grams);
            SelectMold(toy);
            InjectPowder(grams);
            TimeSpan heatingTime = toy.GetHeatingTime();
            HeatMold(heatingTime);
            ExtractToy();
            ConsoleColor color = toy.GetColor();
            PaintToy(color);
            Console.ForegroundColor = current;
        }

        #region Toy construction methods

        private void PreparePowder(int grams)
        {
            Console.WriteLine("Preparing {0} grams of powder", grams);
        }

        private void SelectMold(Toy toy)
        {
            Console.WriteLine("Selecting mold {0}", toy.GetType().Name);
        }

        private void InjectPowder(int grams)
        {
            Console.WriteLine("Injecting {0} grams of powder", grams);
        }

        private void HeatMold(TimeSpan duration)
        {
            Console.WriteLine("Heating for {0} minutes", duration.TotalMinutes);
        }

        private void ExtractToy()
        {
            Console.WriteLine("Extracting toy");
        }

        private void PaintToy(ConsoleColor color)
        {
            Console.WriteLine("Painting toy {0}", color.ToString());
        }

        #endregion

    }
    
}
