using ClassLibrary.Interfaces;

namespace ClassLibrary.AbstractFactories;
public interface IArrayGeneratorFactory
{
    public IArrayGenerator CreateArrayGenerator();
}
