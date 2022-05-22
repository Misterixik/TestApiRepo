using Abp.Domain.Entities;

namespace Domain
{
    public class User : Entity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }






    }
}