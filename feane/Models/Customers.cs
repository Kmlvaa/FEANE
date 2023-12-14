using System.ComponentModel.DataAnnotations;

namespace Feane.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public string ImageName { get; set; }
    }
}
