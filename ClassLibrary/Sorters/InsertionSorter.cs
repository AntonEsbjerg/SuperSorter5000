using ClassLibrary.Interfaces;

namespace ClassLibrary.Sorters;
public class InsertionSorter : ISuperSorter
{
    public int[] Sort(int[] intArray)
    {
        for (int i = 1; i < intArray.Length; ++i)
        {
            int key = intArray[i];
            int j = i - 1;

            while (j >= 0 && intArray[j] > key)
            {
                intArray[j + 1] = intArray[j];
                --j;
            }
            intArray[j + 1] = key;
        }
        return intArray;
    }
}
