using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CSharp_restApi.Logic
{
    class Logic
    {
        public static RestClient restclient;
        public static RestRequest postrequest;
        public static IRestResponse postresponse;
        public static RestRequest GetRequest;
        public static IRestResponse GetResponse;
        public void call()
        {
            restclient = new RestClient("https://reqres.in/api/");
        }

        public bool RegisterUser(string q, string p)
        {
            try
            {
                postrequest.RequestFormat = DataFormat.Json;
                postrequest.AddParameter("email", q);
                postrequest.AddParameter("password", p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool ValidCredentials()
        {
            try
            {
                postresponse = restclient.Execute(postrequest);
                int id = (int)postresponse.StatusCode;
                if ((id == 200))
                {
                    return true;
                }
                else
               
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public RestRequest Get()
        {
            GetRequest = new RestRequest("users", Method.GET);
            return GetRequest;

        }
        public RestRequest Post()
        {
            postrequest = new RestRequest("register", Method.POST);
            return postrequest;

        }
        public bool User()
        {
            try
            {
                GetResponse = restclient.Execute(GetRequest);
                var obj1 = JObject.Parse(GetResponse.Content);
                var list = obj1.SelectToken("data");
                String response = GetResponse.Content;
                if (response != " ")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
