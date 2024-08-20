using System.ComponentModel.DataAnnotations;

namespace Housing.Database.Models
{
    public class Invoicing
    {
        [Key]
        public Guid Uid { set; get; }

        public Guid UidUser { set; get; }

        public decimal Value { set; get; }

        public string Description { set;get; }

        public Guid Status { set; get; }

        public DateTime BuyDate { set; get; }

        public DateTime FinishDate { set; get; }
    }
}
