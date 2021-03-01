using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int Index { get; set; }
        public int PageSize { get; set; }
        public int TotalPage { get; set; }
        public int TotalItem { get; set; }

    }
}
