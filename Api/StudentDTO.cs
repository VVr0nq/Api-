using Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

    }

}

