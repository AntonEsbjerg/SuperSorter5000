using ClassLibrary.AbstractFactories;
using ClassLibrary.Interfaces;
using ClassLibrary.Sorters;

namespace ClassLibrary.Factories.SuperSorterFactories;
public class InsertionSorterFactory : ISuperSorterFactory
{
    public ISuperSorter CreateSuperSorterGenerator() => new InsertionSorter();
}
