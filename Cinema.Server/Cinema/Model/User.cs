using Microsoft.AspNetCore.Cors;

namespace Cinema.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() {
            Id = 1;
            Name = "Nick";
            Email = "test@test.com";
            Password = "password";
        }
    }
}
