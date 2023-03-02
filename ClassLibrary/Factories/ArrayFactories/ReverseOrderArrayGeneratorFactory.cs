using ClassLibrary.AbstractFactories;
using ClassLibrary.ArrayGenerators;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Factories.ArrayFactories;
public class ReverseOrderArrayGeneratorFactory : IArrayGeneratorFactory
{
    public IArrayGenerator CreateArrayGenerator() => new ReverseOrderArrayGenerator();
}
