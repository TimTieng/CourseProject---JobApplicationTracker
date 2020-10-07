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

namespace TiengInClassWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
