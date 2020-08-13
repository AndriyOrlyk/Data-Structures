using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CoctailSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var left = 0;
            var right = Items.Count - 1;
            
            while(left < right)
            {
                for(var i = left; i < right; i++)
                {
                    if(Items[i].CompareTo(Items[i+1]) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                right--;

                for (var i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                    }
                }
                left++;
            }
        }
    }
}
