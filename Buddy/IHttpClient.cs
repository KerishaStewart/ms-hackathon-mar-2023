namespace Buddy
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> PostAsync(string message);
    }
}
