using System.ComponentModel.DataAnnotations;

namespace EternaTemplate.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public int ImagesId { get; set; }
        public Images Images { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}
