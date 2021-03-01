using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Dashboard
{
    public class DashboardDTO
    {
        public int M { get; set; }
        public int Y { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
    }

    public class DashboardModelVIP
    {
        public int M { get; set; }
        public int Y { get; set; }
        public string Title { get; set; }
        public long Like { get; set; }
        public long Cmt { get; set; }
        public long Listen { get; set; }
        public long Download { get; set; }
    }
}
