using Domain.Base;
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
            Code = 200;
            Msg = "Get OK";
        }
    }
    public class NotFoundReponse<T> : Response<T>
    {
        public NotFoundReponse()
        {
            Code = 404;
            Msg = "Not Found";
        }
    }
    public class BadRequestResponse<T> : Response<T>
    {
        public BadRequestResponse()
        {
            Code = 400;
            Msg = "Something Error";
        }
    }


    public class CommandResponse<T> : Response<T> where T: AuditableBaseEntity
    {
        public string ObjectType { get; set; }
        public int ObjectId { get; set; }

    }

    public class CommandOK<T> : CommandResponse<T> where T: AuditableBaseEntity
    {
        public CommandOK()
        {
            Code = 200;
            ObjectType = typeof(T).FullName;
        }
    }
    public class CommandFail<T> : CommandResponse<T> where T : AuditableBaseEntity
    {
        public CommandFail()
        {
            Code = 400;
            ObjectType = typeof(T).FullName;
        }
    }




}
