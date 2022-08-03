using System;
namespace BetterPath
{
    public class Cardinal
    {
        public Boolean GoToSouth(int[,] Mountain, int x, int y)
        {
            try
            {
                return Compare(Mountain[x, y], Mountain[x, y + 1]);
            }
            catch
            {
                return false;
            }
        }
        public Boolean GoToEast(int[,] Mountain, int x, int y)
        {
            try
            {
                return Compare(Mountain[x, y], Mountain[x + 1, y]);
            }
            catch
            {
                return false;
            }
        }
        public Boolean GoToWest(int[,] Mountain, int x, int y)
        {

            try
            {
                return Compare(Mountain[x, y], Mountain[x - 1, y]);
            }
            catch
            {
                return false;
            }
        }

        public Boolean Compare(int val1, int val2)
        {

            if (val1 > val2)
            {
                return true;
            }
            return false;
        }
    }
}

