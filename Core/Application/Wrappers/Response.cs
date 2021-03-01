using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Wrappers
{
    public class Response<T>
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public T Data { get; set; }
        public Response()
        {

        }
    }
}
