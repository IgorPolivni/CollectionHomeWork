using System.Collections.Generic;

namespace CollectionHomeWork
{
    public class MyList : List<int>
    {
        public new void Sort()
        {
            if (Count > 1)
            {
                int count = new int();
                do
                {
                    count = new int();
                    for (int i = 0; i < Count - 1; i++)
                    {
                        if (this[i] > this[i + 1])
                        {
                            count++;
                            int temp = this[i];
                            this[i] = this[i + 1];
                            this[i + 1] = temp;
                        }
                    }
                } while (count != 0);
            }
        }
    }
}
