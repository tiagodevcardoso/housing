using System.ComponentModel.DataAnnotations;

namespace Housing.Database.Models
{
    public class UserBuyItem
    {
        [Key]
        public Guid Uid { set; get; }

        public Guid UidUser { set; get; }

        public Guid UidItem { set; get; }
    }
}
