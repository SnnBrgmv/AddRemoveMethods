using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddRemoveMethods
{
    public class ArrayHelper
    {
        public static string[] Add(ref string[] arr, string value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
            return arr;
        }
        public static string[] Remove(ref string[] arr, string value)
        {
            int removeIndex = Array.IndexOf(arr, value);
            if (removeIndex == -1)
            {
                Console.WriteLine("Value is not found in Array");
            }

            for (int i = removeIndex; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            Array.Resize(ref arr, arr.Length - 1);

            return arr;
        }

    }
}
