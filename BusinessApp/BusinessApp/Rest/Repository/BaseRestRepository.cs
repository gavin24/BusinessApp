using BusinessApp.Models;
using BusinessApp.Rest.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.Rest.Repository
{
    public class BaseRestRepository<T> : IBaseRestRepository<T> where T : Model
    {
        public async Task Delete(long id,string url)
        {
            var httpClient = new HttpClient();
            await httpClient.DeleteAsync(string.Concat(url, id));
            //return todoItems;
        }


        public async Task<IList<T>> FindAll(string query, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url);
            var todoItems = JsonConvert.DeserializeObject<List<T>>(response);
            return todoItems;
        }
        public async Task<IList<T>> FindAllById(long id, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url + id.ToString());
            var todoItems = JsonConvert.DeserializeObject<List<T>>(response);
            return todoItems;
        }
        public async Task<IList<T>> FindAllByDate(DateTime dt, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url + dt.ToString());
            var todoItems = JsonConvert.DeserializeObject<List<T>>(response);
            return todoItems;
        }
        public async Task<T> GetByString(long id, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url+ id.ToString());
            var todoItems = JsonConvert.DeserializeObject<T>(response);
            return todoItems;
        }
        public async Task<T> Get(string email, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url + email);
            var todoItems = JsonConvert.DeserializeObject<T>(response);
            return todoItems;
        }
        public async Task<long> Save(T itemToUpdate, string url)
        {
            var httpClient = new HttpClient();
            var data = JsonConvert.SerializeObject(itemToUpdate);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, content);
            return JsonConvert.DeserializeObject<long>(response.Content.ReadAsStringAsync().Result);
        }

    
            public async Task SaveOrUpdate(long itemIndex, T itemToUpdate,string url)
        {
            var httpClient = new HttpClient();
            var data = JsonConvert.SerializeObject(itemToUpdate);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync(string.Concat(url, itemToUpdate), content);
         ///   return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<T> Get(long id, string url)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(url + id.ToString());
            var todoItems = JsonConvert.DeserializeObject<T>(response);
            return todoItems;
        }
    }
}
