namespace Hemuppgift_Arv_Temp.Game
{
    public abstract class Player
    {
        public string? userId;

        public Player(string userId)
        {
            this.userId = userId;
        }

        public string getUserId(string userId)
        {
            return userId;
        }

        public abstract int TakePins(Board board);
    }

    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId) { }

        // Override the abstract takePins method
        public override int TakePins(Board board)
        {
            Random random = new Random();
            int maxPins = Math.Min(3, board.GetNoPins());  // Maximum of 3 pins or however many are left
            int pins = random.Next(1, maxPins + 1);

            board.TakePins(pins);
            Console.WriteLine($"{userId} (Computer) took {pins} pins.");
            return pins;
        }
    }

    public class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) { }

        // Override the abstract takePins method
        public override int TakePins(Board board)
        {
            int pins;
            bool isValid = false;

            do
            {
                Console.WriteLine($"{userId}, how many pins would you like to take? (1-3)");
                pins = int.Parse(Console.ReadLine());

                if (pins >= 1 && pins <= 3 && pins <= board.GetNoPins())
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid number of pins. Try again.");
                }

            } while (!isValid);

            board.TakePins(pins);
            return pins;
        }

    }



}
