using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.ResQuery
{
    public class ResponseQuery<T>
    {
        public int TotallRecord { get; set; }
        public IReadOnlyList<T> Data { get; set; }
    }

    public class ResponseQueryable<T>
    {
        public int TotallRecord { get; set; }
        public T Data { get; set; }
    }
}
