using System.Text;
using System.Net;

namespace EVE_Online_Fleet_Pings;
public static class Connection
{
    public static void Post(string uri, string message)
    {
        MainWindow.Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        HttpRequestMessage request = new(HttpMethod.Post, uri);
        request.Content = new StringContent(message, Encoding.UTF8, "application/json");
        MainWindow.Client.SendAsync(request).ContinueWith(responseTask =>
        {
            Console.WriteLine("Response: {0}", responseTask.Result);
        });
    }
}