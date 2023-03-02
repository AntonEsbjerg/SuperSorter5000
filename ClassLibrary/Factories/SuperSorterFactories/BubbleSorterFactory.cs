using ClassLibrary.AbstractFactories;
using ClassLibrary.Interfaces;
using ClassLibrary.Sorters;

namespace ClassLibrary.Factories.SuperSorterFactories;
public class BubbleSorterFactory : ISuperSorterFactory
{
    public ISuperSorter CreateSuperSorterGenerator() => new BubbleSorter();
}
