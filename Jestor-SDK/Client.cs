using Jestor_SDK.Exceptions;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Jestor_SDK
{
    class Client
    {
        protected string Org { get; private set; }
        protected string Token { get; private set; }


        public Client(string org, string token)
        {
            this.Org = org;
            this.Token = token;
        }

        public string CallFunctions(string path, string arguments)
        {
            try
            {
                string url = string.Format("https://{0}.api.jestor.com/v3/low-code-execution/", this.Org);
                using(var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                   // var comment = new ProductInfoHeaderValue(new ProductHeaderValue("Jestor SDK Client"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", this.Token);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                  //client.DefaultRequestHeaders.UserAgent.Add(comment);

                    var response = client.PostAsync(path, new StringContent(arguments)).Result;

                    if (((long)response.StatusCode) > 209)
                        throw new JestorException(response);


                    return response.Content.ReadAsStringAsync().Result;

                }
            }
            catch(JestorException e)
            {
                throw e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
