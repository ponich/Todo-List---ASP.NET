using System.Collections.Generic;

namespace TodoNet.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public List<Todo> Todos { get; set; } = new List<Todo>();
    }
}