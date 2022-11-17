using Jestor_SDK.Filters;
using Jestor_SDK.Types;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Jestor_SDK
{
    public sealed class Table<T> where T : class
    {
        private string TableName { get; set; }
        private Client client { get; set; }

        public Table(string tableName, string org, string token)  {
            this.TableName = tableName;
            this.client = new Client(org, token);
        }
        public List<T> Get(List<Filter> filters = null, int limit =100, int page= 1,string sort = null, List<string> fieldsToSelect = null, string fetchType = "single")
        {
            var args = new List<dynamic>();
            args.Add(this.TableName);
            args.Add(filters);
            args.Add(limit);
            args.Add(page);
            args.Add(sort);
            args.Add(fieldsToSelect);
            args.Add(fetchType);


            dynamic arg = new ExpandoObject();
            arg.arguments =  args.ToArray();
            var jsonResponse = this.client.CallFunctions("fetch", JsonSerializer.Serialize(arg));
            JestorResponseList jestorResponse = JsonSerializer.Deserialize<JestorResponseList>(jsonResponse);
            return JsonSerializer.Deserialize<List<T>>(JsonSerializer.Serialize(jestorResponse.data));

        }

        public T Insert(T obj)
        {
            var args = new List<dynamic>();
            args.Add(this.TableName);
            args.Add(obj);
            dynamic arg = new ExpandoObject();
            arg.arguments = args.ToArray();
            var jsonResponse = this.client.CallFunctions("createObject", JsonSerializer.Serialize(arg));

            JestorReponseItem jestorResponse = JsonSerializer.Deserialize<JestorReponseItem>(jsonResponse);
            return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(jestorResponse.data));
        }

        public bool Delete(int recordId)
        {
            var args = new List<dynamic>();
            args.Add(this.TableName);
            args.Add(recordId);
            dynamic arg = new ExpandoObject();
            arg.arguments = args.ToArray();
            var jsonResponse = this.client.CallFunctions("removeObject", JsonSerializer.Serialize(arg));

            JestorReponseItem jestorResponse = JsonSerializer.Deserialize<JestorReponseItem>(jsonResponse);
            return Convert.ToBoolean(jestorResponse.data.ValueKind.ToString());
        }

        public T Update(int recorId, Dictionary<string, dynamic> dataToUpdate)
        {
            
            var field = string.Format("id_{0}", this.TableName);
            
            dataToUpdate.Add(field, recorId);

            var args = new List<dynamic>();
            args.Add(this.TableName);           
          
            args.Add(dataToUpdate);
            args.Add(null);
            dynamic arg = new ExpandoObject();
            arg.arguments = args.ToArray();
            var jsonResponse = this.client.CallFunctions("updateObject", JsonSerializer.Serialize(arg));

            JestorReponseItem jestorResponse = JsonSerializer.Deserialize<JestorReponseItem>(jsonResponse);
            return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(jestorResponse.data));
        }
    
    }
}
