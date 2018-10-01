using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class SpinTheWheel
    {
        Random rand = new Random();
        public int winningNumber;
        public void Spin(Random rand)
        {
            winningNumber = rand.Next(1, 37);
        }
    }
}