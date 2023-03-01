using System.Diagnostics;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Helpers;
public class WatchProvider : IWatchProvider
{
    private readonly Stopwatch watch = new();

    public void Start()
    {
        watch.Restart();
        watch.Start();
    }

    public long Stop()
    {
        watch.Stop();
        return watch.ElapsedMilliseconds;
    }
}
