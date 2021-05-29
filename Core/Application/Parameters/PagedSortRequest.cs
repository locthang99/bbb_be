using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Parameters
{
    public class PagedSortRequest
    {
        public int Index { get; set; }
        public int PageSize { get; set; }
        public string SortBy { get; set; }
        public bool SortASC { get; set; }

        public PagedSortRequest()
        {
            Index = 0;
            PageSize = 10;
            SortBy = "Id";
            SortASC = true;
        }
    }
}
