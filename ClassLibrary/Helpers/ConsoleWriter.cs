using ClassLibrary.Interfaces;

namespace ClassLibrary.Helpers;
public class ConsoleWriter : IOutputProvider
{
    public void Output(string output)
    {
        Console.Write(output);
    }

    public void OutputLine(string output)
    {
        Console.WriteLine(output);
    }
}
