// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using ClassLibrary.Factories.ArrayFactories;
using ClassLibrary.Factories.SuperSorterFactories;
using ClassLibrary.Helpers;
using ClassLibrary.Interfaces;

IEnumerable<IArrayGenerator> arrayGenerators = new List<IArrayGenerator>()
{
    new RandomisedArrayGeneratorFactory().CreateArrayGenerator(),
    new NearlySortedArrayGeneratorFactory().CreateArrayGenerator(),
    new ReverseOrderArrayGeneratorFactory().CreateArrayGenerator(),
};
IOutputProvider outputProvider = new ConsoleWriter();
IWatchProvider watchProvider = new WatchProvider();
ISortManager sortManager = new SortManager(
    new List<ISuperSorter>() {
        new ShellSorterFactory().CreateSuperSorterGenerator(),
        new BubbleSorterFactory().CreateSuperSorterGenerator(),
        new InsertionSorterFactory().CreateSuperSorterGenerator(),
    },
    outputProvider,
    watchProvider);
sortManager.TestSorters(arrayGenerators);
