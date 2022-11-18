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

        [TestMethod]
        public void InsertRecord()
        {
            var jestor = new Jestor<TarefasProjetos>(this.org, this.token);
            var obj = new TarefasProjetos
            {
                name = "Tarefa",
                duracao = 7,
                fase = "Em desenvolvimento"
            };

            jestor.Tables("tarefas_do_projeto").Insert(obj);
        }

        [TestMethod]
        public void UpdateDate()
        {
            int recordId = 1;
            var dtc = new Dictionary<string, dynamic>();
            dtc.Add("name", "Teste update 1");
            dtc.Add("duracao", 40);
            dtc.Add("fim", new DateTime(2022, 12, 9));

            var jestor = new Jestor<TarefasProjetos>(this.org, this.token);
          
            var dados = jestor.Tables("tarefas_do_projeto").Update(recordId, dtc);

            Assert.AreEqual("Teste update 1", dados.name);
        }

        [TestMethod]
        public void DeleteData()
        {
            int recordId = 12;
            var jestor = new Jestor<TarefasProjetos>(this.org, this.token);
            bool isOK = jestor.Tables("tarefas_do_projeto").Delete(recordId);
            

            Assert.AreEqual(true, isOK);
        }

        [TestMethod]
        public void CreateUser()
        {
            var jestor = new Jestor<object>(this.org, this.token);
            var _user = jestor.User().CreateUser("vinicius_belnuovo@hotmail.com", "", 18001, "Vini", true, Jestor_SDK.Types.Seats.member);
            
            Assert.AreEqual("vinicius_belnuovo@hotmail.com", _user.email);
        }

        [TestMethod]
        public void Get()
        {
            var jestor = new Jestor<object>(this.org, this.token);
            var filters = new List<Filter>();
            filters.Add(new Filter("email", "vinicius.belnuovo@jestor.com", "string", Operators.like));

      
            var dados = jestor.User().Get(filters);
            Assert.AreEqual(1, dados.Count);
        }
    }
}
