using System.ComponentModel.DataAnnotations;

namespace Housing.Database.Models
{
    public class Status
    {
        [Key]
        public Guid Uid { set; get; }

        public string Name { set; get; }

        public bool Active { set; get; }
    }
}
