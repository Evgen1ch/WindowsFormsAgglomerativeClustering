using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgglomerativeClustering
{
    public static class ArrayUtility
    {
        public static T[] GetRow<T>(int row, T[,] array) where T: struct
        {
            if (row > array.GetLength(0))
                throw new IndexOutOfRangeException("Row is out of range");
            int size = array.GetLength(1);

            T[] result = new T[size];
            for (int j = 0; j < size; j++)
            {
                result[j] = array[row, j];
            }
            return result;
        }
    }
}
