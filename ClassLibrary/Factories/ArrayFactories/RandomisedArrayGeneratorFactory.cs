using ClassLibrary.AbstractFactories;
using ClassLibrary.ArrayGenerators;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Factories.ArrayFactories;
public class RandomisedArrayGeneratorFactory : IArrayGeneratorFactory
{
    public IArrayGenerator CreateArrayGenerator() => new RandomisedArrayGenerator();
}
