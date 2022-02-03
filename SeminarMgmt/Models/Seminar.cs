using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarMgmt.Models
{
    public class Seminar
    {
        [Key]
        public int SeminarId { get; set; }

        public string SeminarName { get; set; }

        public string SeminarDescription { get; set; }

        public DateTime StartTime { get; set;}

        public DateTime EndTime { get; set; }

        [Display(Name ="Seminar Type")]
        public string SeminarType { get; set; }

        public string SpeakersName { get; set; }

        
        [Display(Name ="Organised By")]
        public string OrganizerName { get; set; }

        public string OrganizerLocation { get; set; }

        public List<Attendee> Attendees { get; set; }
      
    }
}
