using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeAndLadder
{
    public class Uc_4RepeatTill100
    {
        int position = 0;
        public void Repeat()
        {
            int position = 0;
            int current_position = 0;
            int start_position = 0;
            const int Winning = 100;
            const int NoPlay = 0;
            const int Ladder = 1;
            const int Snake = 2;
            Random r = new Random();
            while (position < Winning)
            {
                int random = r.Next(1, 7);
                int option = r.Next(0, 3);
                switch (option)
                {
                    case NoPlay:
                        Console.WriteLine("You Got No Play");
                        Console.WriteLine("-------");
                        break;

                    case Ladder:
                        position = current_position;
                        if (position < Winning)
                        {
                            current_position = current_position + random;
                            Console.WriteLine("Player Ladder By:" + random);
                            if (current_position > Winning)
                            {
                                current_position = position;
                            }
                        }
                        break;

                    case Snake:
                        if (current_position > 0)
                        {
                            Console.WriteLine("Player Snake By:" + random);
                            current_position = current_position - random;
                        }
                        else if (current_position <= 0)
                        {
                            current_position = start_position;
                            current_position = position;
                        }
                        break;
                }
            }
            Console.WriteLine("You are the Final Position Is:" + position);
            Console.ReadLine();
            //Random random = new Random();

            //while (position <= 100)
            //{
            //    int num = random.Next(1, 7);
            //    int check = random.Next(0, 3);
            //    switch (check)
            //    {
            //        case 0:
            //            Console.WriteLine("Player is in the same position");
            //            break;
            //        case 1:
            //            position += num;
            //            Console.WriteLine("Player position is : " + position);
            //            break;
            //        case 2:
            //            position -= num;
            //            Console.WriteLine("Player position is : " + position);
            //            if (position < 0)
            //            {
            //                position = 0;
            //                Console.WriteLine("Player position change to 0 . So the player again Restart From O");
            //            }
            //            break;
            //    }
            //}   
        }
    }
}
