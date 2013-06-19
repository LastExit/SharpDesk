using System.Collections.Generic;
using Newtonsoft.Json;
using SharpDesk.Infrastructure;
using SharpDesk.Infrastructure.Http;
using SharpDesk.Model;

namespace SharpDesk.Repository.Json
{
    public class DynamicRepository : RepositoryBase, IFreshdeskRepository<object>
    {
        private IHttpRestService _http;
        private string _apiMethod;

        public DynamicRepository(string apiMethod)
        {
            _http = new HttpRestService();
            _apiMethod = apiMethod;
        }

        public dynamic GetSingle(Args args)
        {
            var uri = Domain + "/helpdesk/" + _apiMethod + "/" + args["id"] + ".json";
            args.Add("apikey",ApiKey);
            var response = _http.Get(args, uri);
            return JsonConvert.DeserializeObject<dynamic>(response);
        }

        public List<dynamic> GetList(Args args)
        {
            var uri = Domain + "/helpdesk/" + _apiMethod + ".json";
            if (args.ContainsKey("filter"))
                uri += "?" + args["filter"];
            args.Add("apikey", ApiKey);
            var response = _http.Get(args, uri);
            return JsonConvert.DeserializeObject<dynamic>(response).ToObject<List<dynamic>>();
        }
    }
}
