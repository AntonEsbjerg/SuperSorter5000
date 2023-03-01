// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using ClassLibrary.Helpers;
using ClassLibrary.Interfaces;
using ClassLibrary.Sorters;

IArrayGenerator arrayGenerator = new ArrayGenerator();
IOutputProvider outputProvider = new ConsoleWriter();
IWatchProvider watchProvider = new WatchProvider();
ISortManager sortManager = new SortManager(
    new List<ISuperSorter>() {
        new ShellSorter(),
        new BubbleSorter(),
        new InsertionSorter(),
    },
    outputProvider,
    watchProvider);
int[] array = arrayGenerator.Generate(10000, 5);
sortManager.TestSorters(array);

