using System.Collections.Generic;

namespace Indexers
{
    public class Numbers
    {
        private List<int> numberList = new List<int>();

        public Numbers()
        {
            for (int i = 1; i < 21; i++)
            {
                numberList.Add(i);
            }
        }

        public int this [int index]
        {
            get
            {
                return numberList[index];
            }

            set
            {
                numberList[index] = value;
            }
        }
    }
}
