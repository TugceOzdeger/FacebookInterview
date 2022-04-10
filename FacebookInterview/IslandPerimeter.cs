namespace FacebookInterview
{
    public class IslandPerimeter
    {
        /*
         You are given a map in form of a two-dimensional integer grid where 1 represents 
         land and 0 represents water.Grid cells are connected horizontally/vertically (not diagonally). 
         The grid is completely surrounded by water, and there is exactly one island 
         (i.e., one or more connected land cells).The island doesn't have "lakes" 
         (water inside that isn't connected to the water around the island). 
         One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 
         100. Determine the perimeter of the island.

         Input:[[0,1,0,0],[1,1,1,0],[0,1,0,0],[1,1,0,0]]
         Output: 16
         */

        public int FindIslandPerimeter()
        {
            var grid = SetData();
            var counter = 0;

            for(var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    if (grid[i,j] == 1)
                    {
                        if (i == 0)
                        {
                            if (j == 0 || grid[i, j-1] != 1)
                                counter += 3;
                            else
                                counter += 2;
                        }
                        else
                        {
                            if (j == 0)
                            {
                                if(grid[i-1,j] == 1)
                                    counter += 2;
                                else
                                    counter += 3;
                            }                               
                            else
                            {
                                if (grid[i-1,j] == 1 && grid[i,j-1] == 1)
                                    counter += 1;
                                else if (grid[i-1,j] == 1 && grid[i,j-1] != 1)
                                    counter += 2;
                                else 
                                    counter += 3;
                            }                               
                        }
                    }
                }
            }

            return counter;
        }

        public int[,] SetData()
        {
            int[,] grid = new int[4,4];

            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 4; j++)
                {
                    if (i == 0)
                    {
                        if (j == 1)
                            grid[i, j] = 1;
                    }
                    else if(i == 1)
                    {
                        if(j == 0 || j == 1 || j == 2)
                            grid[i,j] = 1;
                    }
                    else if (i == 2)
                    {
                        if (j == 1)
                            grid[i,j] = 1;
                    }
                    else if (i == 3)
                    {
                        if (j == 0 || j == 1)
                            grid[i,j] = 1;
                    }
                    else grid[i,j] = 0;
                }
            }
            return grid;
        }
    }
}
