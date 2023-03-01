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
    public void TestSorters(int[] intArray)
    {
        foreach (var item in SuperSorters)
        {
            //OutputProvider.OutputLine($"You unsortedarray is: ");

            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    OutputProvider.Output($"{intArray[i]} ");
            //}

            OutputProvider.OutputLine($"¨Will now sort with {item.GetType()}");

            WatchProvider.Start();
            int[] sortedResult = item.Sort(intArray);
            long elapsedMs = WatchProvider.Stop();

            OutputProvider.OutputLine($"You array has been sort in: {elapsedMs} ms, the resulting array is: ");

            //for (int i = 0; i < sortedResult.Length; i++)
            //{
            //    OutputProvider.Output($"{sortedResult[i]} ");
            //}
        }

    }
}
