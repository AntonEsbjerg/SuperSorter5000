// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using ClassLibrary.ArrayGenerators;
using ClassLibrary.Helpers;
using ClassLibrary.Interfaces;
using ClassLibrary.Sorters;

IArrayGenerator arrayGenerator = new ReverseOrderArrayGenerator();
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
int[] array = arrayGenerator.Generate(50000, 5);
sortManager.TestSorters(array);

