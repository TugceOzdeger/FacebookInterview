namespace FacebookInterview
{
    public class ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            var row = 0;
            var result = 0;
            while(result <= n)
            {
                row++;
                result += row;
            }
            return row-1;
        }
    }
}
