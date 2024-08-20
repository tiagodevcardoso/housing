using System.ComponentModel.DataAnnotations;

namespace Housing.Database.Models
{
    public class Items
    {
        [Key]
        public Guid Uid { set; get; }

        public string Name { set; get; }

        public decimal Price { set; get; }

        public string Description { set; get; }

        public string UrlImage { set; get; }
    }
}