using System.ComponentModel.DataAnnotations;

namespace AStandupApi.Data.Models
{
    public class ActivityLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime LogTime { get; set; }

        [Required]
        public string Note { get; set; }
    }
}
