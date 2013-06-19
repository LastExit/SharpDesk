using System.Collections.Generic;
using SharpDesk.Infrastructure;
using SharpDesk.Model;
using SharpDesk.Services.Factory;

namespace SharpDesk.Services
{
    public class TicketService : IFreshdeskService<object>
    {
        private readonly IRepositoryFactory<dynamic> _repoFactory;
        private IFreshdeskRepository<dynamic> _repository;
        public Args args;

        public TicketService()
        {
            _repoFactory = new FreshdeskRepositoryFactory<dynamic>();
            _repository = _repoFactory.Get(typeof(Ticket));
            args = new Args();
        }

        public dynamic Get()
        {
            return _repository.GetSingle(args)["helpdesk_ticket"];
        }

        public List<dynamic> GetAll()
        {
            return _repository.GetList(args);
        }

        public List<dynamic> GetAllNewAndMyOpen()
        {
            var filter = "filter_name=new_and_my_open";
            args.Add("filter", filter);
            return _repository.GetList(args);
        }

    }

    
}
