using System;
namespace BinarySearch.Logic
{
    public class Comparator
    {
        public static Func<int, int, int> comparatorForInt32 = delegate (int lhs, int rhs)
        {
            if (lhs == rhs)
                return 0;

            if (lhs > rhs)
                return 1;

            return -1;
        };
    }
}
