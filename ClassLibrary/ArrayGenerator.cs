using ClassLibrary.Interfaces;

namespace ClassLibrary;
public class ArrayGenerator : IArrayGenerator
{
    private Random _random = new();
    public int[] Generate(int size, int seed)
    {
        _random = new Random(seed);
        int[] intArray = new int[size];
        for (int i = 0; i < intArray.Length; i++)
        {
            intArray[i] = _random.Next(100);
        }
        return intArray;
    }
}
