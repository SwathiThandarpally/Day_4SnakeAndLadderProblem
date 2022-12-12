using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_2DiceRolls
    {
        int position = 0;
        public void RollDice()
        {
            Random random = new Random();
            int position = random.Next(1, 7);
            Console.WriteLine("The number of the Dice is:" +position);
        }
    }
}
