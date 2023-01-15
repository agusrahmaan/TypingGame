namespace TypingGame.NewFolder
{
    public class Stats
    {
        public int Correct;
        public int Missed;
        public int Total;
        public int Accuracy;

        public void CountTotal()
        {
            Total = Correct + Missed;
        }

        public void CountAccuracy()
        {
            Accuracy = Correct * 100 / (Correct+Missed);
        }
    }
}
