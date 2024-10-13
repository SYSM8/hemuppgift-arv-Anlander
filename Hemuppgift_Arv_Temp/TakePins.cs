using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board board = new Board();
            board.SetUp(10);  // Game with 10 pins

            Player humanPlayer = new HumanPlayer("Player 1");  // Human Player
            Player computerPlayer = new ComputerPlayer("Computer"); // AI Player

            Player currentPlayer = humanPlayer;  // Human starts first


            while (board.GetNoPins() > 0)  // Loop trough the pins until there is no one left.
            {
                Console.WriteLine($"\nThere  {board.GetNoPins()} pins remaining.");

                // The current player takes their turn
                int pinsTaken = currentPlayer.TakePins(board);

                Console.WriteLine($"{currentPlayer.GetType().Name} took {pinsTaken} pin(s).");

                // Check if the game is done.
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"{currentPlayer.GetType().Name} wins the game!");
                    break;
                }

                // Go between players
                currentPlayer = (currentPlayer == humanPlayer) ? computerPlayer : humanPlayer;
            }

        }
    }
}
