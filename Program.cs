namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder geame with players");
            //UseCase1
            UC_1WithOnePlayer uC_1WithOnePlayer = new UC_1WithOnePlayer();
            uC_1WithOnePlayer.Position();
            Console.WriteLine("-----------------------");
            //UseCase2
            UC_2DiceRolls uC_2DiceRolls = new UC_2DiceRolls();
            uC_2DiceRolls.RollDice();
            Console.WriteLine("-----------------------");
            //UseCase3
            UC_3CheckPosition uC_3CheckPosition = new UC_3CheckPosition();
            uC_3CheckPosition.Moves();
            Console.WriteLine("-----------------------");
            // UseCase4
            Uc_4RepeatTill100 uc_4RepeatTill100 = new Uc_4RepeatTill100();
            uc_4RepeatTill100.Repeat();
          //UseCase5
            UC_5ExactPositionIs100 uC_5ExactPositionIs100 = new UC_5ExactPositionIs100();
            uC_5ExactPositionIs100.Winning();
            Console.WriteLine("-----------------------");
          //UseCase6
            UC_6ReportNumTimes uC_6ReportNumTimes = new UC_6ReportNumTimes();
            uC_6ReportNumTimes.Report();
            Console.WriteLine("-----------------------");
            //UseCase7
            UC_7WithTwoPlayers uC_7WithTwoPlayers = new UC_7WithTwoPlayers();
            uC_7WithTwoPlayers.Dice();
            uC_7WithTwoPlayers.TwoPlayer();



        }
    }
}