using Jestor_SDK;
using Jestor_SDK.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void Get()
        {
            var _user = new User("belnuovo", "Nzk4NTRkMTMzNjFjMDI48aa1fa7516MTY1NzU0MzkyODc4ZDM5");
            var filters = new List<Filter>();
            filters.Add(new Filter("email", "vinicius.belnuovo@jestor.com", "string", Operators.like));

            //var filter = new Filter("name", "Documentação do Projeto", "string", Operators.CONTAINS);
            //  var teste = JsonSerializer.Serialize(filters.Select(p => p.data).ToArray());
            var dados = _user.Get(filters);
            Assert.AreEqual(1, dados.Count);
        }

        [TestMethod]
        public void Create()
        {
            var _user = new User("belnuovo", "Nzk4NTRkMTMzNjFjMDI48aa1fa7516MTY1NzU0MzkyODc4ZDM5");
           
            var dados = _user.CreateUser("vinicius_belnuovo@hotmail.com", "senh@007", 18001, "Vini", true, Jestor_SDK.Types.Seats.member);
            Assert.AreEqual("vinicius_belnuovo@hotmail.com", dados.email);
        }
    }
}
