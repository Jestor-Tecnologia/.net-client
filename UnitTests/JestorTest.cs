using Jestor_SDK;
using Jestor_SDK.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTests.TableTypes;

namespace UnitTests
{
    [TestClass]
    public class JestorTest
    {
        private string org;
        private string token;

        [TestInitialize]
        public void Init()
        {
            this.org = "";
            this.token = "";
        }

        [TestMethod]
        public void ListRecords()
        {
            var jestor = new Jestor<TarefasProjetos>(this.org, this.token);
            var filters = new List<Filter>();
            filters.Add(new Filter("name", "Documentação do Projeto", "string", Operators.like));

            var dados = jestor.Tables("tarefas_do_projeto").Get(filters);


            Assert.AreEqual(true, dados.Count > 0);

        }
    }
}
