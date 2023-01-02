﻿namespace Blog.Application.Features.Writers.DTOs
{
    public class ListWriterDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public List<string> Photos { get; set; }
    }
}
