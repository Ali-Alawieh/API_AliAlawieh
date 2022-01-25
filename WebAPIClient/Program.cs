﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebAPIClient.log;
using Newtonsoft.Json;



namespace WebAPIClient
{
    internal class Program
    {
        
        
        
        private static async Task ProcessRepositories()
        {


            var httpClient = new HttpClient();
            var url = "https://localhost:7279/Log";
            var bodyObject = new Log(22,"Send_Request");
            var content = new StringContent(JsonConvert.SerializeObject(bodyObject),Encoding.UTF8,"application/json");
            var result = await httpClient.PostAsync(url, content);
            var result2 = await httpClient.GetAsync(url);

            Console.WriteLine(result);
            Console.WriteLine(result2);
 
        }
        
        public static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }
    }
}

