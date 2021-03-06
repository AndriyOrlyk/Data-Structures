﻿using System;

namespace Algorithm
{
    public class BubbleSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;
            for(var j = 0; j < count - 1; j++)
            {
                for (var i = 0; i < count - j - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if(a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
            }
        }
    }
}
