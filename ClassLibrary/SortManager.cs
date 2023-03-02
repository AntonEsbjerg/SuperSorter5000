using ClassLibrary.Interfaces;

namespace ClassLibrary;
public class SortManager : ISortManager
{
    public IEnumerable<ISuperSorter> SuperSorters { get; set; }
    public IOutputProvider OutputProvider { get; set; }
    public IWatchProvider WatchProvider { get; set; }
    public SortManager(IEnumerable<ISuperSorter> superSorters, IOutputProvider outputProvider, IWatchProvider watchProvider)
    {
        SuperSorters = superSorters;
        OutputProvider = outputProvider ?? throw new ArgumentNullException(nameof(outputProvider));
        WatchProvider = watchProvider ?? throw new ArgumentException(nameof(watchProvider));
    }
    public void TestSorters(IEnumerable<IArrayGenerator> arrayGenerators)
    {
        foreach (var item in SuperSorters)
        {
            OutputProvider.OutputLine($"Will now sort with {item.GetType()}");

            foreach (var arrayGenerator in arrayGenerators)
            {
                OutputProvider.OutputLine($"Will sort an array of type with {arrayGenerator.GetType()}");
                WatchProvider.Start();
                int[] sortedResult = item.Sort(arrayGenerator.Generate(50000, 123));
                long elapsedMs = WatchProvider.Stop();
                OutputProvider.OutputLine($"You array has been sorted in: {elapsedMs} ms, the resulting array is: ");
            }
            OutputProvider.OutputLine("");
        }

    }
}
