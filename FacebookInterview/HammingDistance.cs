using System;

namespace FacebookInterview
{
    public class HammingDistance
    {
        private string binaryX;
        private string binaryY;

        public int FindDistance(int binaryX1, int binaryY1)
        {
            var distance = 0;
            FixBinary(binaryX1, binaryY1);
                         
            for(var i = 0; i<binaryX.Length; i++)
            {
                if (binaryX[i] != binaryY[i])
                    distance++;
            }

            return distance;
        }

        private void FixBinary(int binaryX1, int binaryY1)
        {
            SetData(binaryX1, binaryY1);
            if (binaryX.Length == binaryY.Length) return;
            string zeros = null;
            bool result = binaryX.Length > binaryY.Length;

            int difference;
            if (result)
                difference = binaryX.Length - binaryY.Length;
            else
                difference = binaryY.Length - binaryX.Length;

            for (var i = 0; i < difference; i++)
                zeros += "0";

            if(!result)
                binaryX = zeros + binaryX;
            else
                binaryY = zeros + binaryY;
        }

        private void SetData(int binaryX1, int binaryY1)
        {
            binaryX = Convert.ToString(binaryX1, 2);
            binaryY = Convert.ToString(binaryY1, 2);
        }
    }
}
