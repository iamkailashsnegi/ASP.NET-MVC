using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProjectWebApp.Models
{
    public class Project
    {
        [Display(Name="Customer Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be empty")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name Should be min 2 and max 20 length")]
        public string Cust_Name { get; set; }


        [Display(Name = "Project Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name cannot be empty")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name Should be min 2 and max 20 length")]
        public string Project_Name { get; set; }

        [Display(Name = "Project Id")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Id cannot be empty")]
        public int Id { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime SD { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime ED { get; set; }

        [Required]
        [Display(Name = "Project Status")]
        public string Project_Status { get; set; }

        
        [Display(Name = "Location/Group")]
        [Required(ErrorMessage = "Please Select")]
        public string Location_Group { get; set; }

        [Display(Name = "PayRoll State")]
        [Required(ErrorMessage = "Please Select")]
        public string PayRoll_State { get; set; }

        [Display(Name = "Sales Person")]
        [Required(ErrorMessage = "Please Select")]
        public string Sales_Person { get; set; }

        [Display(Name = "Project Category")]
        [Required(ErrorMessage = "Please Select")]
        public string Proj_Cat { get; set; }

        [Display(Name = "Project Type")]
        [Required(ErrorMessage = "Please Select")]
        public string Proj_Type { get; set; }

        [Display(Name = "Sub-Domain")]
        [Required(ErrorMessage = "Please Select")]
        public string Sub_Dom { get; set; }

        [Display(Name = "Times Sheet Representative")]
        [Required(ErrorMessage = "Please Select")]
        public string TSP { get; set; }

        [Display(Name = "Client-Invoice Group")]
        [Required(ErrorMessage = "Please Select")]
        public string CIG { get; set; }

        [Display(Name = "Timesheet Type")]
        [Required(ErrorMessage = "Please Select")]
        public string TimesheetType { get; set; }

        [Display(Name = "Is VMS Timesheet")]
        [Required(ErrorMessage = "Please Select")]
        public bool IVT { get; set; }

        [Display(Name = "Practice Type")]
        [Required(ErrorMessage = "Please Select")]
        public string Prac_Type { get; set; }

        [Required(ErrorMessage = "Please Select")]
        public string Recruiter { get; set; }

    }
}