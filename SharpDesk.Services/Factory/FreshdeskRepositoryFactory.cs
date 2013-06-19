using System;
using SharpDesk.Model;
using SharpDesk.Repository.Json;

namespace SharpDesk.Services.Factory
{
    public class FreshdeskRepositoryFactory<T> : IRepositoryFactory<T>
    {
        public IFreshdeskRepository<T> Get(Type target)
        {
            if (target == typeof (Ticket))
                return new DynamicRepository("tickets") as IFreshdeskRepository<T>;

            return null;
        }
    }
}
