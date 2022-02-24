namespace Factorial
{
    public class ClassFact
    {
        public double Fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * Fact(n - 1);
        }
    }
}
