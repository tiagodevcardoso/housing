using System.ComponentModel.DataAnnotations;

namespace Housing.Database.Models
{
    public class Users
    {
        [Key]
        public Guid Uid { set; get; }

        public string Username { set; get; }

        public string Password { set; get; }

        public string Fullname { set; get; }

        public string DocumentNumber { set; get; }

        public bool IsCustomer { set; get; }

        public bool IsAdministrator { set; get; }

        public bool Active { set; get; }
    }
}