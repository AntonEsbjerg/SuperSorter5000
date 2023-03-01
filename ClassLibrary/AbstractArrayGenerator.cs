using ClassLibrary.Interfaces;

namespace ClassLibrary;
public abstract class AbstractArrayGenerator : IArrayGenerator
{
    private Random _random = new();
    public int[] Generate(int size, int seed)
    {
        _random = new Random(seed);
        var intArray = new int[size];
        for (var i = 0; i < intArray.Length; i++)
        {
            intArray[i] = _random.Next(100);
        }
        int[] resultArray = PostProcessArray(intArray);
        return resultArray;
    }
    protected abstract int[] PostProcessArray(int[] array);
}
