using System.ComponentModel.DataAnnotations;

namespace AStandupApi.Data.Models
{
    public class MeetingNote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime MeetingDate { get; set; }

        [Required]
        public string Notes { get; set; }
    }
}
