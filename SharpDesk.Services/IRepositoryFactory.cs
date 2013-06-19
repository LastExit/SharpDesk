using System;
using SharpDesk.Model;

namespace SharpDesk.Services
{
    public interface IRepositoryFactory<T>
    {
        IFreshdeskRepository<T> Get(Type target);
    }
}
