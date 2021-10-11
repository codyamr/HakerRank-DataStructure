using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
   public class ArrayPractise
    {

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
    }
}
