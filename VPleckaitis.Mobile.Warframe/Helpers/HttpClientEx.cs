using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VPleckaitis.Mobile.Warframe.Models.External;

namespace VPleckaitis.Mobile.Warframe.Helpers
{
    public class HttpClientEx
    {
        private static HttpClientEx _instance;
        private const string serverAddress = "http://content.warframe.com/dynamic/";

        private readonly HttpClientHandler httpClientHandler;
        private readonly HttpClient httpClient;
        public HttpClientEx()
        {
            httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
            httpClient = new HttpClient(httpClientHandler) { BaseAddress = new Uri($"{serverAddress}") };
        }

        public static HttpClientEx Client
        {
            get
            {
                if(_instance == null)
                { 
                    _instance = new HttpClientEx(); 
                }

                return _instance;
            }
        }

        public async Task<string> GetAsync(string url)
        {
            var res = await httpClient.GetAsync(url);
            var content = await res.Content.ReadAsStringAsync();
            return content;
        }

        //TODO - fix get generic model
        //public async Task<T> GetAsync<T>(string url)
        //{
        //    var res = await httpClient.GetAsync(url);
        //    var content = await res.Content.ReadAsStringAsync();
        //    return content.Map<T>();
        //}

    }
}
