using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class ArrayPractise
    {

        //Ds
        public static List<int> reverseArray(List<int> a)
        {
            //{ 1, 5, 8, 9 };
            var newListItem = new List<int>();
            for (int i = a.ToArray().Length - 1; i >= 0; i--)
            {
                newListItem.Add(a.ToArray()[i]);
            }
            return newListItem;
        }

        //2DArray
        public static int hourglassSum(int[][] arr)
        {


            int maxSum = int.MinValue;
            int rows = arr.Length - 2;
            for (int j = 0; j < rows; j++)
            {
                //0 1 2 3 4 5
                //0 1 2 3 4 5
                //0 1 2 3 4 5
                //0 1 2 3 4 5
                //0 1 2 3 4 5
                //0 1 2 3 4 5
                int columns = arr[j].Length - 2;

                for (int k = 0; k < columns; k++)
                {
                    var xxxxxx1 = k; var xxxxxx2 = j;




                    int sum = arr[j][k] + arr[j][k + 1] + arr[j][k + 2]
                                        + arr[j + 1][k + 1]
                        + arr[j + 2][k] + arr[j + 2][k + 1] + arr[j + 2][k + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}
