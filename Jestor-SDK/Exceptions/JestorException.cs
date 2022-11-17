using Jestor_SDK.Types;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Jestor_SDK.Exceptions
{
    public class JestorException: Exception
    {
        private long statusCode;
        private string message;

        public override string Message { get; }
        public JestorException()
        {

        }

        public JestorException(HttpResponseMessage response)
        {
            var jsonData = response.Content.ReadAsStringAsync().Result;

            JestorResponseError obj = JsonSerializer.Deserialize< JestorResponseError>(jsonData);
            this.statusCode = ((long)response.StatusCode);
            this.message = obj.data.message;

            this.Message = string.Format("{0} - {1}", this.statusCode, this.message);
        }
    }
}
