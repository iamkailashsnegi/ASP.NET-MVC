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
        public DataType SD { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DataType ED { get; set; }

        [Required]
        [Display(Name = "Project Status")]
        public string Project_Status { get; set; }


        [Display(Name = "Location/Group")]
        public string Location_Group { get; set; }

        [Display(Name = "PayRoll State")]
        public string PayRoll_State { get; set; }

        [Display(Name = "Sales Person")]
        public string Sales_Person { get; set; }

        [Display(Name = "Project Category")]
        public string Proj_Cat { get; set; }

        [Display(Name = "Project Type")]
        public string Proj_Type { get; set; }

        [Display(Name = "Sub-Domain")]
        public string Sub_Dom { get; set; }

        [Display(Name = "Times Sheet Representative")]
        public string TSP { get; set; }

        [Display(Name = "Client-Invoice Group")]
        public string CIG { get; set; }

        [Display(Name = "Timesheet Type")]
        public string TimesheetType { get; set; }

        [Display(Name = "Is VMS Timesheet")]
        public bool IVT { get; set; }

        [Display(Name = "Practice Type")]
        public string Prac_Type { get; set; }

        public string Recruiter { get; set; }

    }
}