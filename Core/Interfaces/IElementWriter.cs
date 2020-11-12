using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IElementWriter
    {
        void Write(List<IElement> elements, string filePath);
    }
}
