using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IElementReader
    {
        List<IElement> Read(string filePath);
    }
}
