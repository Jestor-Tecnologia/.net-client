using Jestor_SDK.Filters;
using Jestor_SDK.Types;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Text.Json;

namespace Jestor_SDK
{
    public sealed class User
    {
        private Client client { get; set; }

        public User(string org, string token) {
            this.client = new Client(org, token);
        }

        public List<Users> Get(List<Filter> filters = null, int limit = 100, int page = 1, string sort = null)
        {
            var args = new List<dynamic>();
            
            args.Add(filters);
            args.Add(limit);
            args.Add(page);
            args.Add(sort);            


            dynamic arg = new ExpandoObject();
            arg.arguments = args.ToArray();
            var jsonResponse = this.client.CallFunctions("fetchUsers", JsonSerializer.Serialize(arg));
            JestorResponseList jestorResponse = JsonSerializer.Deserialize<JestorResponseList>(jsonResponse);
            return JsonSerializer.Deserialize<List<Users>>(JsonSerializer.Serialize(jestorResponse.data));

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="profile"></param>
        /// <param name="sendEmailToValidation"></param>
        /// <param name="seat">Tipo do usuário, por default será membro</param>
        /// <returns></returns>
        public Users CreateUser(string email, string password, int profileId, string name = null, bool sendEmailToValidation = false, Seats seat = Seats.member)
        {
            var args = new List<dynamic>();
            args.Add(email);
            args.Add(password);
            args.Add(profileId);
            args.Add(name);
            args.Add(sendEmailToValidation);
            
            args.Add(seat);
            dynamic arg = new ExpandoObject();
            arg.arguments = args.ToArray();
            var jsonResponse = this.client.CallFunctions("createUser", JsonSerializer.Serialize(arg));

            JestorReponseItem jestorResponse = JsonSerializer.Deserialize<JestorReponseItem>(jsonResponse);
            return JsonSerializer.Deserialize<Users>(JsonSerializer.Serialize(jestorResponse.data));
        }
         
    }
}
