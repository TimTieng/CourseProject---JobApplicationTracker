/*
Class: MSSA Cloud Application Development 
Cohort: Fort Bragg Cohort 9
Student: Tim Tieng
Description: MSSA Individual Course Project - MSSA Job Application Tracker
Revised By: Tim Tieng
Revised On: 30 September 2020
Revisions Made: 
    1. Added links to careers page on InterestedJobsView
    2. Added Company description to each hiring partner block
    3. Started and implemented pagination feature in InterestedJobs View - NOT COMPETE
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiengInClassWebApp.Models
{
    
    public class JobApplication
    {
        [Key]
        [Required]
        [Display(Name ="Job Requisition Number")]
        public int jobRequisitionNumber { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string jobTitle { get; set; }

        [Required]
        [Display(Name = "Company")]
        public string hiringCompany { get; set; }

        [Required]
        [Display(Name = "Location")]
        public string jobLocation { get; set; }
        
        [DataType(DataType.Date)]
        [Required]
        [Display(Name = "Submission Date")]
        public DateTime applicationSubmissionDate { get; set; }

        [Display(Name = "Application Notes")]
        public string applicationNotes { get; set; }//Added on 17SEP2020
    }
}
