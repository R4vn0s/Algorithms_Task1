using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class bubble
    {
        int tmp;

        public int[] sort(int[] arr) 
        {
            int num = arr.Length;
            for (int i = 0; i < num - 1; i++)
                for (int j = 0; j < num - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap tmp and arr[i] int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
            return arr;
        }
       
    }
}
