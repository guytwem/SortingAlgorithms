using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class ListSortExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">The type needs to have a comparator.</typeparam>
    /// <param name="_list"></param>
    public static void BubbleSort<T>(this List<T> _list) where T : IComparable
    {
        T temp;

        for (int i=0; i <= _list.Count - 2; i++)
        {
            for (int j=0; j <= _list.Count -2; j++)
            {
                IComparable first = _list[j];
                IComparable second = _list[j + 1];

                int comparison = first.CompareTo(second);
                // >0 means that first is after second
                if (comparison > 0)
                {
                    temp = _list[j + 1];
                    _list[j + 1] = _list[j];
                    _list[j] = temp;
                }
            }
        }
    }
    public static void InsertionSort(long[] inputArray)
    {
        long j = 0;
        long temp = 0;
        for (int index = 1; index < inputArray.Length; index++)
        {
            j = index;
            temp = inputArray[index];
            while ((j > 0) && (inputArray[j - 1] > temp))
            {
                inputArray[j] = inputArray[j - 1];
                j = j - 1;
            }
            inputArray[j] = temp;
        }
    }
}
