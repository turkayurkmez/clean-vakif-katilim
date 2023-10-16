namespace Naming
{
    public class DirtyCode
    {
        List<int[]> items = new List<int[]>();

        public List<int[]> getThem()
        {
            List<int[]> ints = new List<int[]>();
            foreach (var item in items)
            {
                if (item[0] == 4)
                {
                    ints.Add(item);
                }
            }

            return ints;
        }
    }

    public class CleanCode
    {
        List<int[]> cellsOnAGameBoard = new List<int[]>();
        public List<int[]> GetFlaggedCellsOnBoard()
        {
            List<int[]> flaggedCells = new List<int[]>();
            foreach (var cell in cellsOnAGameBoard)
            {
                if (cell[0] == Flags.FlaggedCell)
                {
                    flaggedCells.Add(cell);
                }
            }

            return flaggedCells;
        }
    }

    public class Flags
    {
        public const int EmptyCell = 0;
        public const int FlaggedCell = 4;
    }
}
