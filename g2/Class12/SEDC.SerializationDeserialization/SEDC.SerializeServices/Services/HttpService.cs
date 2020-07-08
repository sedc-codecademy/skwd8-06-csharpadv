using System;
using System.Net.Http;

namespace SEDC.SerializeServices.Services
{
    public class HttpService
    {
        public static string GetData(string url)
        {
            //HttpClient _client = new HttpClient();
            //_client.Dispose();

            using (HttpClient _client = new HttpClient())
            {
                HttpResponseMessage response = _client.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    return responseString;
                }
                else
                {
                    return $"Request failed! Message: {response.RequestMessage} StatusCode: {response.StatusCode}";
                }
            }
        }
    }
}
