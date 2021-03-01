using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Comment
{
    public class CommentDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
    }
}
