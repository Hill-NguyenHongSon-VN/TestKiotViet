using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKiotViet
{
    public class Helper
    {
       
        public int CheckCocaCola(int n)
        {
            try
            {
                int x = n;
                int y = 0;
                int kq = n;
                do
                {
                    y = x % 3;
                    x = x / 3;
                    kq += x;
                    x = x + y;
                } while (x > 2);
                return kq;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error 500: {ex.Message}");
                return default(int);
            }
        }
        public int DynamicProgramingArray(int[] arrayLst)
        {
           
            //int min = 0;
            //foreach (var item in leftlimit)
            //{
            //    Console.WriteLine($"So leftlimit: {item}");
                
            //}
            //foreach (var item in rightlimit )
            //{
            //    Console.WriteLine($"So rightlimit: {item}");

            //}
            //// loop through and process each index in the heights array
            //for (int i = 0; i < arrayLst.Length-1; i++)
            //{
            //    // use the Find function to get the bounds of the rectangle
            //    min = Math.Min(min, (Find(arrayLst,arrayLst[i], i) - Find(arrayLst, arrayLst[i+1], i)));
            //}

            return 0;

        }
        //int Find(int[] heights, int limit, int idx)
        //{
        //    // keep searching for the limit as long as we are within the bounds of the array
        //    // and we haven't found a lower height
        //    while (limit >= 0 && limit < heights[idx]+limit && heights[idx] <= heights[limit])
        //    {
        //        // use recursion here to find the next value and then update the array
        //        limit[idx] = Find(heights, limit, limit[idx]);
        //    }
        //    return limit[idx];
        //}


    }
}
