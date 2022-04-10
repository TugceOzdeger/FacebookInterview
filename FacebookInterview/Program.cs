using System;

namespace FacebookInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var result = new MiddleNode();
            //result.FindMiddle();

            //var resultBinary = new BinaryTree();
            //resultBinary.LevelOrderBottom();

            //var cells = new PrisonCell();
            //cells.PrisonAfterNDays();

            //var binaryString = new ReverseBits();
            ////binaryString.ReverseBinaryStrings();
            //Console.WriteLine(binaryString.ReverseBinaryStrings());
            //Console.WriteLine(binaryString.ReverseBinaryToInteger());

            //var islandPerimeter = new IslandPerimeter();
            //islandPerimeter.FindIslandPerimeter();

            var hammingDistance = new HammingDistance();
            hammingDistance.FindDistance(4,1);
        }
    }
}
