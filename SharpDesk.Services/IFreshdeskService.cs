using System.Collections.Generic;

namespace SharpDesk.Services
{
    public interface IFreshdeskService<T>
    {
        T Get();
        List<T> GetAll();
    }
}
