namespace SharpDesk.Infrastructure
{
    public interface IHttpRestService
    {
        string Get(Args args, string uri);
    }
}
