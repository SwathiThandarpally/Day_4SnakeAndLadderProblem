using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC_3CheckPosition
    {
        int position = 0;
        public void Moves()
        {
            Random random = new Random();
            int position = random.Next(1,7);
            int check = random.Next(0, 3);

            if (check == 0)
            {
                Console.WriteLine("Player is in the same position");
            }
            else if (check > 0)
            {
                position += position;
                Console.WriteLine("Player position is : " + position);
            }
            else
            {
                position -= position;
                Console.WriteLine("Player position is : " + position);
            }


        }
    }
}
