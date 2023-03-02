using ClassLibrary.AbstractFactories;
using ClassLibrary.Interfaces;
using ClassLibrary.Sorters;

namespace ClassLibrary.Factories.SuperSorterFactories;
public class ShellSorterFactory : ISuperSorterFactory
{
    public ISuperSorter CreateSuperSorterGenerator() => new ShellSorter();
}
