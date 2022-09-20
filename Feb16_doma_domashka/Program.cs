using System;

namespace Feb16_doma_domashka
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Ədədlərdən ibarət array qəbul edən method yazın.Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.

            int[] array = new int[] { 5, 8, 2, 10, 15, 58, 65, 15, 14, 18, 95, 41, 15, 156, 1653, 15, 1, 513, 31, 153, 74, 752, 74, 5, 4, 96, 85, 85, 5, 6, 5, 6, 6, 541, 96 };

            CustomSort(array);                          // metod posilayu
            foreach (int item in array)
            {
                Console.WriteLine(item);                // eto mne pishet kajdiy item moego arraya
            }
            #endregion
        }
        static int[] CustomSort(int[] arr)
        {
            int b;

            for (int i = 0; i < arr.Length; i++)        // for vnutri fora pootmushto u nas dva loopa
            {
                for (int m=+i; m < arr.Length; m++)
                {
                    if (arr[i] > arr[m])                 // nado ne zabit pro int b
                    {
                        b = arr[i];
                        arr[i] = arr[m];
                        arr[m] = b;
                    }
                }
            }
            return arr;                                 // tak kak nash return arr a metod int[] mi vernem v main znacenie i vivedem na writeline
        }
    }
}
