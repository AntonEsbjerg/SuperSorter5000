namespace ClassLibrary.Interfaces;
public interface ISortManager
{
    public IEnumerable<ISuperSorter> SuperSorters { get; set; }
    public IOutputProvider OutputProvider { get; set; }
    public void TestSorters(int[] intArray);
}
