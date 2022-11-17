using System;
using System.Collections.Generic;
using System.Text;

namespace Jestor_SDK
{
    public class Jestor<T> where T : class
    {
        protected string Org { get; private set; }
        protected string Token { get; private set; }

       

        public Jestor(string org, string token)
        {
            this.Org = org;
            this.Token = token;
          
        }

        public Table<T> Tables(string tableName)
        {
            return new Table<T>(tableName, this.Org, this.Token);
        }

        public User User()
        {
            return new User(this.Org, this.Token);
        }
    }
}
