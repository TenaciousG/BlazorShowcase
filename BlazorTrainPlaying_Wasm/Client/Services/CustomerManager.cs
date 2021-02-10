using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorTrainPlaying_Wasm.Shared.Models;
using Newtonsoft.Json;

namespace BlazorTrainPlaying_Wasm.Client.Services
{
    public class CustomerManager : APIRepository<Customer>
    {
        HttpClient http;

        public CustomerManager(HttpClient _http)
            : base(_http, "Customer", "CustomerId")
        {
            http = _http;
        }

        public async Task<IEnumerable<Customer>> SearchByContactName(string ContactName)
        {
            try
            {
                var arg = WebUtility.HtmlEncode(ContactName);
                var url = $"Customer/{arg}/searchbycontactname";
                var result = await http.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string responseBody = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<APIListOfEntityResponse<Customer>>(responseBody);
                if (response.Success)
                    return response.Data;
                else
                    return new List<Customer>();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return null;
            }
        }


    }
}
