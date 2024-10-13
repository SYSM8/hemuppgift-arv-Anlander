namespace Hemuppgift_Arv_Temp.Game
{
    public class Board
    {
        private int noPins;

        public void TakePinsGame()
        {

        }

        public int SetUp(int start)
        {
            return noPins = start;
        }
        public void TakePins(int pins)
        {
            if (pins > noPins || pins < 0)
            {
                throw new ArgumentException("Invalid number of pins taken.");
            }
            noPins -= pins;
        }


        public int GetNoPins()
        {
            return noPins;
        }
    }

}

