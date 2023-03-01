using ClassLibrary.Interfaces;

namespace ClassLibrary.Sorters;
public class BubbleSorter : ISuperSorter
{
    public int[] Sort(int[] intArray)
    {
        int temp;
        for (var i = 0; i < intArray.Length - 1; i++)
        {
            for (var j = 0; j < intArray.Length - 1; j++)
            {
                if (intArray[j] > intArray[j + 1])
                {
                    temp = intArray[j + 1];
                    intArray[j + 1] = intArray[j];
                    intArray[j] = temp;
                }
            }
        }
        return intArray;
    }
}
