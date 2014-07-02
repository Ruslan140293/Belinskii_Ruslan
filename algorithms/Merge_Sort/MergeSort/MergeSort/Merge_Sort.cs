
using System.Linq;
using System.Collections.Generic;

namespace MergeSort
{
    public class GenericList<T>
    {
        void Add(T input)
        {
        }
    }
    public static class Merge_Sort
    {
        public static List<int> Sort(List<int> input)
        {
            List<int> Result = new List<int>();
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            if (input.Count <= 1)
                return input;

            int midpoint = input.Count / 2;
            for (int i = 0; i < midpoint; i++)
                Left.Add(input[i]);
            for (int i = midpoint; i < input.Count; i++)
                Right.Add(input[i]);

            Left = Sort(Left); //Recursion! :o
            Right = Sort(Right);
            Result = Merge(Left, Right);

            return Result;
        }

        public static List<int> Merge(List<int> Left, List<int> Right)
        {
            List<int> Result = new List<int>();
            while (Left.Count > 0 && Right.Count > 0)
            {
                if (Left[0] < Right[0])
                {
                    Result.Add(Left[0]);
                    Left.RemoveAt(0);
                }
                else
                {
                    Result.Add(Right[0]);
                    Right.RemoveAt(0);
                }
            }

            while (Left.Count > 0)
            {
                Result.Add(Left[0]);
                Left.RemoveAt(0);
            }

            while (Right.Count > 0)
            {
                Result.Add(Right[0]);
                Right.RemoveAt(0);
            }

            return Result;
        }
        public static int[] sort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(sort(massive.Take(mid_point).ToArray()), sort(massive.Skip(mid_point).ToArray()));
        }
        public static int[] merge(int[] mas1, int[] mas2)
        {
            int a = 0, b = 0;
            int[] result = new int[mas1.Length + mas2.Length];
            for (int i = 0; i < mas1.Length + mas2.Length; i++)
            {
                if (b < mas2.Length && a < mas1.Length)
                    if (mas1[a] > mas2[b] && b < mas2.Length)
                        result[i] = mas2[b++];
                    else
                        result[i] = mas1[a++];
                else
                    if (b < mas2.Length)
                        result[i] = mas2[b++];
                    else
                        result[i] = mas1[a++];
            }
            return result;
        }
    }
}

