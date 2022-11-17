using Jestor_SDK;
using Jestor_SDK.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using UnitTests.TableTypes;

namespace UnitTests
{
    [TestClass]
    public class TableTest
    {
        /*[TestMethod]
        public void Get()
        {
            var table = new Table<TarefasProjetos>("tarefas_do_projeto");
            var filters = new List<Filter>();
            filters.Add(new Filter("name", "Documentação do Projeto", "string", Operators.like));

            //var filter = new Filter("name", "Documentação do Projeto", "string", Operators.CONTAINS);
          //  var teste = JsonSerializer.Serialize(filters.Select(p => p.data).ToArray());
            var dados = table.Get(filters);
            Assert.AreEqual("Documentação do Projeto", dados[0].name);
        }

        [TestMethod]
        public void InsertData()
        {
            string nome = "Teste Insert SDK 2";
            var table = new Table<TarefasProjetos>("tarefas_do_projeto", this.);
            var obj = new TarefasProjetos
            {
                name = nome,
                duracao = 7,
                fase = "Em desenvolvimento"
            };

            var dados = table.Insert(obj);

            Assert.AreEqual(nome, dados.name);
        }

        [TestMethod]
        public void DeleteData()
        {
            int recordId = 12;
            var table = new Table<TarefasProjetos>("tarefas_do_projeto");
            

            var dados = table.Delete(recordId);

            Assert.AreEqual(true, dados);
        }

        [TestMethod]
        public void UpdateDate()
        {
            int recordId = 1;
            var dtc = new Dictionary<string, dynamic>();
            dtc.Add("name", "Teste update 1");
            dtc.Add("duracao", 40);
            dtc.Add("fim", new DateTime(2022, 12, 9));

            var table = new Table<TarefasProjetos>("tarefas_do_projeto");


            var dados = table.Update(recordId, dtc);

            Assert.AreEqual("Teste update 1", dados.name);
        }*/
    }
}
