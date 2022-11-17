using Jestor_SDK;
using Jestor_SDK.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ClientTest
    {
        /*private string org;
        private string token;

        [TestMethod]
        public void CallFunctionFetch()
        {
            string path = "fetch";
            var args = new ArgumentFetch
            {
                limit = 1,
                table_name = "tarefas_do_projeto"
            };
            //var args = new List<dynamic>();
            //args.Add("tarefas_do_projeto");
            //args.Add(null);
            //args.Add(1);
            dynamic data = new ExpandoObject();
            data.arguments = new List<ArgumentFetch> { args }.ToArray();

            var jestorCli = new Client(this.org, this.token);

            var response = jestorCli.CallFunctions(path, JsonSerializer.Serialize(data));
        }

        [TestInitialize]
        public void Init()
        {
            this.org = "";
            this.token = "";
        }
    }
}
