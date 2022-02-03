using System.ComponentModel.DataAnnotations;

namespace SeminarMgmt.Models
{
    public class Organizer
    {
        [Key]
        public int OrganiserID { get; set; }
        public string Name { get; set; }
     

        [StringLength(10)]
        public string ContactNo { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public int SeminarId { get; set; }
        public virtual Seminar Seminar { get; set; }
    }
}
