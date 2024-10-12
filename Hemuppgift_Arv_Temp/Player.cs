namespace Hemuppgift_Arv_Temp
{
    public abstract class Player
    {
        private string userId;

        public Player(string userId)
        {
            this.userId = userId;
        }

        public string GetUserId()
        {
            return userId;
        }
    }
}
