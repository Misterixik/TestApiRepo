using Abp.Domain.Entities;
using Domain;

namespace Domain
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }






    }
}