using ClassLibrary.AbstractFactories;
using ClassLibrary.ArrayGenerators;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Factories.ArrayFactories;
public class NearlySortedArrayGeneratorFactory : IArrayGeneratorFactory
{
    public IArrayGenerator CreateArrayGenerator() => new NearlySortedArrayGenerator();
}
