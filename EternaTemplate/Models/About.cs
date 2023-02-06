using System.ComponentModel.DataAnnotations;

namespace EternaTemplate.Models
{
    public class About
    {
        public int Id { get; set; }
        public int ImagesId { get; set; }
        public Images Images { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(100)]
        public string Text { get; set; }
    }
}
