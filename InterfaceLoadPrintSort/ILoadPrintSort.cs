using System;

namespace InterfaceLoadPrintSort
{
    public interface ILoadPrintSort
    {
        string[] Print();
        void Load(string fileName);
        void SortByName();
        void SortByValue();
    }
}
