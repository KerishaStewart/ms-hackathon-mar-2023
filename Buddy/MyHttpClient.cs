namespace Buddy
{
    public class MyHttpClient : IHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public MyHttpClient(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<HttpResponseMessage> PostAsync(string message)
        {
            var url = $"{_baseUrl}/PostAsync?message={message}";
            var response = await _httpClient.PostAsync(url, null);
            return response;
        }
    }
}
