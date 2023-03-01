namespace ClassLibrary.ArrayGenerators;
public class NearlySortedArrayGenerator : AbstractArrayGenerator
{
    private readonly Random _random = new();

    protected override int[] PostProcessArray(int[] intArray)
    {
        Array.Sort(intArray);
        for (int i = 0; i < intArray.Length / 100; i++)
        {
            int firstIndexInSwap = 0;
            int secondIndexInSwap = 0;
            while (firstIndexInSwap == secondIndexInSwap)
            {
                firstIndexInSwap = _random.Next(intArray.Length);
                secondIndexInSwap = _random.Next(intArray.Length);
            }
            int firstValueInSwap = intArray[firstIndexInSwap];
            intArray[firstIndexInSwap] = intArray[secondIndexInSwap];
            intArray[secondIndexInSwap] = firstValueInSwap;
        }
        return intArray;
    }
}
