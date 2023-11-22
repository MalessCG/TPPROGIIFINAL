using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionFront.Http
{
    public class HttpHelper
    {
        private static HttpHelper instance;
        private HttpClient client;

        private HttpHelper()
        {
            client = new HttpClient();
        }

        public static HttpHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new HttpHelper();
            }
            return instance;
        }

        public async Task<ResponseHttp> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            return new ResponseHttp(result.StatusCode, content);
        }

        public async Task<ResponseHttp> PostAsync(string url, string json)
        {
            var result = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "Application/Json"));
            var content = await result.Content.ReadAsStringAsync();
            return new ResponseHttp(result.StatusCode, content);
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PutAsync(url, content);
            var response = "";

            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }

            return response;
        }
    }
}
