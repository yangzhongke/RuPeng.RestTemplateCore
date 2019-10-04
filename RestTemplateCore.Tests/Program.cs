using System;
using System.Net.Http;

namespace RestTemplateCore.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (HttpClient httpClient = new HttpClient())
            {
                RestTemplate rest = new RestTemplate(httpClient);

                Console.WriteLine("---querying---------");
                var headers = new HttpRequestMessage().Headers;
                headers.Add("aa", "666");
                var ret1 = rest.GetForEntityAsync<Product[]>("http://ProductService/api/Product/", headers).Result;
                Console.WriteLine(ret1.StatusCode);
                if (ret1.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var p in ret1.Body)
                    {
                        Console.WriteLine($"id={p.Id},name={p.Name}");
                    }
                }

                Console.WriteLine("---add new---------");
                Product newP = new Product();
                newP.Id = 888;
                newP.Name = "xinzeng";
                newP.Price = 88.8;
                var ret = rest.PostAsync("http://ProductService/api/Product/", newP).Result;
                Console.WriteLine(ret.StatusCode);
            }
            Console.ReadKey();
        }
    }
}
