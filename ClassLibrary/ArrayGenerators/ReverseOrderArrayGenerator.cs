namespace ClassLibrary.ArrayGenerators;
public class ReverseOrderArrayGenerator : AbstractArrayGenerator
{
    protected override int[] PostProcessArray(int[] intArray)
    {
        Array.Sort(intArray);
        Array.Reverse(intArray);
        return intArray;
    }
}
