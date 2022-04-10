using System;

namespace FacebookInterview
{
    public class ReverseBits
    {
        /*
         Input: 00000010100101000001111010011100
         Output: 00111001011110000010100101000000
         Explanation: The input binary string 00000010100101000001111010011100 
         represents the unsigned integer 43261596, so return 964176192 which its binary 
         representation is 00111001011110000010100101000000.
         
         Input: 11111111111111111111111111111101
         Output: 10111111111111111111111111111111
         Explanation: The input binary string 11111111111111111111111111111101 
         represents the unsigned integer 4294967293, so return 3221225471 which its binary 
         representation is 10111111111111111111111111111111.
         */

        public string ReverseBinaryStrings()
        {
            string binaryString = "00000010100101000001111010011100";
            var charArray = binaryString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int ReverseBinaryToInteger()
        {
            string binaryString = "00000010100101000001111010011100";
            var integer = Convert.ToInt32(binaryString, 2);
            var charArray = integer.ToString().ToCharArray();
            Array.Reverse(charArray);
            integer = Convert.ToInt32(new string(charArray));
            return integer;
        }

        public bool IsDuplicate(int N)
        {
            int[] dup = {1, 2, 3, 3, 5};

            var temp = 0;
            for(var i = 0; i < N; i++)
            {
                if (temp == dup[i])
                    return true;
                temp = dup[i];
            }

            return false;
        }
    }
}
