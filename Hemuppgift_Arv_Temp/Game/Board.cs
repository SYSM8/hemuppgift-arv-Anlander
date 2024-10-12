namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        private int noPins;

        public void TakePinsGame()
        {

        }

        public int SetUp(int start)
        {
            return noPins = start;
        }
        public int TakePins(int takepins)
        {
            return noPins - takepins;
        }

        public int GetNoPins()
        {
            return noPins;
        }
    }

}

