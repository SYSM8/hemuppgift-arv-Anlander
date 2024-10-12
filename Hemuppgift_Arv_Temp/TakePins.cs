using Hemuppgift_Arv_Temp.Game;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            Board boardGame = new Board();
            //board.TakePinsGame();
            boardGame.SetUp(10);
            Console.WriteLine($"Game starts with {boardGame.GetNoPins()}");

            //Console.WriteLine($"Board starts with {StartPins} pins");

            //Console.Write("Remove pins: ");
            //int removePin = Convert.ToInt32(Console.ReadLine());
            //int updatedPins = board.TakePins(removePin);
            //Console.WriteLine($"Board have {updatedPins} pins");

            Console.ReadLine();
        }

    }
}
