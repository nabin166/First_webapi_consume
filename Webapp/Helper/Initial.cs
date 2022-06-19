namespace Webapp.Helper
{
    public class Initial
    {

        public HttpClient init()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44398/");
            return client;
        }
    }
}
