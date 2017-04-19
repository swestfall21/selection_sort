using System;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {66,12,16,88,99,4,23,73,14};
            
            Console.Write("Initial Array : ");
            Console.WriteLine(String.Join(" ", arr));

            Console.Write("Sorted Array : ");
            //Printing array after pass
            Console.WriteLine(String.Join(" ", SelectionSort(arr)));                   
        }

        static int[] SelectionSort(int[] arr) {
            int n = arr.Length;

            for(var i=0; i < n; i++){
                int small = arr[i];
                int pos = i;

                 for(var j = i + 1; j < n; j++)
                 {
                     if(arr[j] < small)
                     {
                         small = arr[j];
                         pos = j;
                     }
                 }

                 int temp=arr[pos];
                 arr[pos] = arr[i];
                 arr[i] = temp;                 
            }
            
            return arr;
        }
    }
}
