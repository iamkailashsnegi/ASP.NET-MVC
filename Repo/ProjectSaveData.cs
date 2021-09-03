using MyProjectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyProjectWebApp.Repo
{
    public class ProjectSaveData
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        public string AddProject(Project Proj)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("Project_Kailash_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cust_Name", Proj.Cust_Name);
            cmd.Parameters.AddWithValue("@Proj_Name", Proj.Project_Name);
            cmd.Parameters.AddWithValue("@Proj_Id", Proj.Id);
            cmd.Parameters.AddWithValue("@Start_Date", Proj.SD);
            cmd.Parameters.AddWithValue("@End_Date", Proj.ED);
            cmd.Parameters.AddWithValue("@Proj_Status", Proj.Project_Status);
            cmd.Parameters.AddWithValue("@Loc_Group", Proj.Location_Group);
            cmd.Parameters.AddWithValue("@PayRoll", Proj.PayRoll_State);
            cmd.Parameters.AddWithValue("@SalesPerson", Proj.Sales_Person);
            cmd.Parameters.AddWithValue("@Proj_Cat", Proj.Proj_Cat);
            cmd.Parameters.AddWithValue("@Proj_Type", Proj.Proj_Type);
            cmd.Parameters.AddWithValue("@Sub_Domain", Proj.Sub_Dom);
            cmd.Parameters.AddWithValue("@TimeSheetRep", Proj.TSP);
            cmd.Parameters.AddWithValue("@ClientInvoice", Proj.CIG);
            cmd.Parameters.AddWithValue("@TimeSheetType", Proj.TimesheetType);
            cmd.Parameters.AddWithValue("@IsVMS", Proj.IVT);
            cmd.Parameters.AddWithValue("@Prac_Type", Proj.Prac_Type);
            cmd.Parameters.AddWithValue("@Recruiter", Proj.Recruiter);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return "Added Successfully";

            }
            else
            {
                return "Not Added";

            }
        }

        public string Edit(Project Proj)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("Project_Kailash_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cust_Name", Proj.Cust_Name);
            cmd.Parameters.AddWithValue("@Proj_Name", Proj.Project_Name);
            cmd.Parameters.AddWithValue("@Proj_Id", Proj.Id);
            cmd.Parameters.AddWithValue("@Start_Date", Proj.SD);
            cmd.Parameters.AddWithValue("@End_Date", Proj.ED);
            cmd.Parameters.AddWithValue("@Proj_Status", Proj.Project_Status);
            cmd.Parameters.AddWithValue("@Loc_Group", Proj.Location_Group);
            cmd.Parameters.AddWithValue("@PayRoll", Proj.PayRoll_State);
            cmd.Parameters.AddWithValue("@SalesPerson", Proj.Sales_Person);
            cmd.Parameters.AddWithValue("@Proj_Cat", Proj.Proj_Cat);
            cmd.Parameters.AddWithValue("@Proj_Type", Proj.Proj_Type);
            cmd.Parameters.AddWithValue("@Sub_Domain", Proj.Sub_Dom);
            cmd.Parameters.AddWithValue("@TimeSheetRep", Proj.TSP);
            cmd.Parameters.AddWithValue("@ClientInvoice", Proj.CIG);
            cmd.Parameters.AddWithValue("@TimeSheetType", Proj.TimesheetType);
            cmd.Parameters.AddWithValue("@IsVMS", Proj.IVT);
            cmd.Parameters.AddWithValue("@Prac_Type", Proj.Prac_Type);
            cmd.Parameters.AddWithValue("@Recruiter", Proj.Recruiter);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return "Edited Successfully";

            }
            else
            {
                return "Not Edited";

            }
        }
        public string Update(Project Proj)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("Project_Kailash_Training", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cust_Name", Proj.Cust_Name);
            cmd.Parameters.AddWithValue("@Proj_Name", Proj.Project_Name);
            cmd.Parameters.AddWithValue("@Proj_Id", Proj.Id);
            cmd.Parameters.AddWithValue("@Start_Date", Proj.SD);
            cmd.Parameters.AddWithValue("@End_Date", Proj.ED);
            cmd.Parameters.AddWithValue("@Proj_Status", Proj.Project_Status);
            cmd.Parameters.AddWithValue("@Loc_Group", Proj.Location_Group);
            cmd.Parameters.AddWithValue("@PayRoll", Proj.PayRoll_State);
            cmd.Parameters.AddWithValue("@SalesPerson", Proj.Sales_Person);
            cmd.Parameters.AddWithValue("@Proj_Cat", Proj.Proj_Cat);
            cmd.Parameters.AddWithValue("@Proj_Type", Proj.Proj_Type);
            cmd.Parameters.AddWithValue("@Sub_Domain", Proj.Sub_Dom);
            cmd.Parameters.AddWithValue("@TimeSheetRep", Proj.TSP);
            cmd.Parameters.AddWithValue("@ClientInvoice", Proj.CIG);
            cmd.Parameters.AddWithValue("@TimeSheetType", Proj.TimesheetType);
            cmd.Parameters.AddWithValue("@IsVMS", Proj.IVT);
            cmd.Parameters.AddWithValue("@Prac_Type", Proj.Prac_Type);
            cmd.Parameters.AddWithValue("@Recruiter", Proj.Recruiter);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return "Update Successfully";

            }
            else
            {
                return "Not Update";

            }
        }

    }
}