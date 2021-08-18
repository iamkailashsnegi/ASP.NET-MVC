using MyProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectWebApp.ViewModel
{
    public class ProjectAddEditViewModel
    {
        public Project Project { get; set; }
        public List<SelectList> ProjectStatusList { get; set; }
        public List<SelectList> LocationGroupList { get; set; }
        public List<SelectList> PayRollStateList { get; set; }
        public List<SelectList> SalesPersonList { get; set; }
        public List<SelectList> ProjectCatList { get; set; }
        public List<SelectList> ProjectTypeList { get; set; }
        public List<SelectList> SubDomainList { get; set; }
        public List<SelectList> TSRList { get; set; }
        public List<SelectList> CIGList { get; set; }
        public List<SelectList> TimeSheetTypeList { get; set; }
        public List<SelectList> PracTypeList { get; set; }
        public List<SelectList> RecruiterList { get; set; }
    }
}