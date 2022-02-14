namespace FrogCrossingRiver
{
    public class CrossingRiver
    {
        /*
         * Problem
         * If the frog has to cross a river of n feet and there are n-1 stones in between at a distance of 1 feet each
         * The frog can jump 1 feet or 2 feet at a time. Not backwards
         * How many ways can the frog cross the river.
         * 1 ft (0 stones) - 1, 2ft (1 stone) - 2, 3ft (2 stones) - 3, 4ft (3 stones) - 5, 5ft (4 stones) - 8
         */
        public int Num_Ways(int n)
        {
            if (n==0 || n == 1)
            {
                return 1;
            }

            return Num_Ways(n - 2) + Num_Ways(n - 1);
        }

        /*
         * Problem
         * This same logic can be applied in the case of Climbing stairs.
         * A person can climb stairs one step at a time or 2 steps at a time
         * How many ways can that person climb n stairs
         */
    }
}
