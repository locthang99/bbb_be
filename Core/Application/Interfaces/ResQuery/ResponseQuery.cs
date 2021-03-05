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
}
