using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarMgmt.Models
{
    public class Attendee
    {
        [Key]   
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
       
        [StringLength(10)]
        public string Phonenumber { get; set; }
  
        [EmailAddress]
        [Required]
        public string Emailaddress { get; set; }
        
        public int SeminarId { get; set; }
        public virtual Seminar Seminar { get; set; }

    }
}
