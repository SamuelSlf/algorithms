using System;

namespace CSharpAlgorithms
{
    public class BinarySearch : IBinarySearch
    {
        public int Execute(int[] array, int target)
        {
            int inicialPosition = 0, finalPosition = array.Length - 1;

            while (inicialPosition <= finalPosition)
            {
                int middlePosition = (inicialPosition + finalPosition) / 2;
                int valueFound = array[middlePosition];

                if (valueFound == target)
                    return middlePosition;

                if (target < valueFound)
                    finalPosition = middlePosition - 1;

                if (target > valueFound)
                    inicialPosition = middlePosition + 1;
            }

            return -1;
        }
    }

    public interface IBinarySearch
    {
        int Execute(int[] array, int key);
    }
}
