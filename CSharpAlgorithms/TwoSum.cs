using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms
{
    public class TwoSum : ITwoSum
    {
        public int[] Execute(int[] input, int target)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (i == j)
                        continue;

                    if (input[i] + input[j] == target)
                        return new int[] { i, j };

                }
            }

            return null;
        }
    }

    public interface ITwoSum
    {
        int[] Execute(int[] input, int target);
    }
}
