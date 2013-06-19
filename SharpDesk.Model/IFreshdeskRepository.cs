using System.Collections.Generic;
using SharpDesk.Infrastructure;

namespace SharpDesk.Model
{
    public interface IFreshdeskRepository<T>
    {
        T GetSingle(Args args);
        List<T> GetList(Args args);
    }
}
