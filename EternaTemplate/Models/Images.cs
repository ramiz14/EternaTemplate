using System.ComponentModel.DataAnnotations;

namespace EternaTemplate.Models
{
    public class Images
    {
        public int Id{ get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(200)]
        public string BelongTo { get; set; }
    }
}
