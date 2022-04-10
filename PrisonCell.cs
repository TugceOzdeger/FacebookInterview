using System.Collections.Generic;
using System.Linq;

namespace FacebookInterview
{
    public class PrisonCell
    {
        /*If a cell has two adjacent neighbors that are both occupied or both vacant, 
        then the cell becomes occupied.
        Otherwise, it becomes vacant.
        Input: cells = [0,1,0,1,1,0,0,1], N = 7
        Output: [0,0,1,1,0,0,0,0]

        Explanation: 
        The following table summarizes the state of the prison on each day:
        Day 0: [0, 1, 0, 1, 1, 0, 0, 1]
        Day 1: [0, 1, 1, 0, 0, 0, 0, 0]
        Day 2: [0, 0, 0, 0, 1, 1, 1, 0]
        Day 3: [0, 1, 1, 0, 0, 1, 0, 0]
        Day 4: [0, 0, 0, 0, 0, 1, 0, 0]
        Day 5: [0, 1, 1, 1, 0, 1, 0, 0]
        Day 6: [0, 0, 1, 0, 1, 1, 0, 0]
        Day 7: [0, 0, 1, 1, 0, 0, 0, 0]

        Input: cells = [1,0,0,1,0,0,1,0], N = 1000000000
        Output: [0,0,1,1,1,1,1,0]*/

        public int[] PrisonAfterNDays()
        {
            int N = 7;
            int[] cells = { 0, 1, 0, 1, 1, 0, 0, 1};
            int[] newCells = { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (var i = 0; i < N; i++)
            {
                var index = 0;

                while (index < cells.Count() - 2)
                {
                    if ((cells[index] == 0 && cells[index + 2] == 0) || 
                        (cells[index] == 1 && cells[index + 2] == 1))
                        newCells[index + 1] = 1;                
                    index++;
                }
            }
            return newCells;
        }

        public List<int> FindUglyNumber(int n) 
        {
            var uglyNumbers = new List<int>{1};
            var index = 2;

            while (uglyNumbers.Count < n)
            {
                if (index % 2 == 0 || index % 3 == 0 || index % 5 == 0)
                    uglyNumbers.Add(index);
                index++;
            }

            return uglyNumbers;
        }
    }
}
