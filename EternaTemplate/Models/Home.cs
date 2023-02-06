using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EternaTemplate.Models
{
    public class Home
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
    }
}
