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
                return "Please Try Again";

            }
        }

        public string Edit(int Id)
        {
            //string a;
            Connection();
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("EditUpdateProjectDetails_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Proj_Id", Id);
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(ds);
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.Cust_Name = Convert.ToString(ds.Tables[0].Rows[i]["Cust_Name"]);
                    obj.Project_Name = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Name"]);
                    obj.SD = Convert.ToString(ds.Tables[0].Rows[i]["Start_Date"]);
                    obj.ED = Convert.ToString(ds.Tables[0].Rows[i]["End_Date"]);
                    obj.Project_Status = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Status"]);
                    obj.Location_Group = Convert.ToString(ds.Tables[0].Rows[i]["Loc_Group"]);
                    obj.PayRoll_State = Convert.ToString(ds.Tables[0].Rows[i]["PayRoll"]);
                    obj.Sales_Person = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.Proj_Cat = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Cat"]);
                    obj.Proj_Type = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Type"]);
                    obj.Sub_Dom = Convert.ToString(ds.Tables[0].Rows[i]["Sub_Domain"]);
                    obj.TSP = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRep"]);
                    obj.CIG = Convert.ToString(ds.Tables[0].Rows[i]["CLientInvoice"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IVT = Convert.ToString(ds.Tables[0].Rows[i]["IsVMS"]);
                    obj.Prac_Type = Convert.ToString(ds.Tables[0].Rows[i]["Prac_Type"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                }
            }
            return "a";
        }
        public string Update(Project Proj)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("EditProjectDetails_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cust_Name", Proj.Cust_Name);
            cmd.Parameters.AddWithValue("@Proj_Name", Proj.Project_Name);
            //cmd.Parameters.AddWithValue("@Proj_Id", Proj.Id);
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