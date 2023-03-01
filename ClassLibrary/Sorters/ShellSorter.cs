using ClassLibrary.Interfaces;

namespace ClassLibrary.Sorters;
public class ShellSorter : ISuperSorter
{
    public int[] Sort(int[] intArray)
    {
        for (int i = intArray.Length / 2; 0 < i; i /= 2)
        {
            for (int j = i; j < intArray.Length; j++)
            {
                int currentKey = intArray[j];
                int k = j;
                while (k >= i && intArray[k - i] > currentKey)
                {
                    intArray[k] = intArray[k - i];
                    k -= i;
                }
                intArray[k] = currentKey;
            }

        }
        return intArray;
    }
}
