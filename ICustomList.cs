using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessson3_1
{
    public interface ICustomList<T>
    {
        void Add(T value);
        //Notebook this[int index] { get; }
        bool Delete(T value);
    }
}
