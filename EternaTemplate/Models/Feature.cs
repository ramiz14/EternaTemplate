using System.ComponentModel.DataAnnotations;

namespace EternaTemplate.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Icon { get; set; }

    }
}
