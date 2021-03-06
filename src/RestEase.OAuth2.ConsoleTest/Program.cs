﻿using System;
using RestEaseOAuth2Test;

namespace RestEase.OAuth2.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var handler = new ClientCredentialsGrantHandler("http://localhost:9090");

            var api = OAuth2RestClient.For<IMyApp>("http://localhost:9090", handler);

            string result = api.GetHelloAsync().Result;

            Console.WriteLine(result);

            int x = 0;
        }
    }
}