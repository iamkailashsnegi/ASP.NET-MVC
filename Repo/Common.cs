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
    public class Common
    {
        private SqlConnection con;

        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }
        public List<SelectList> GetProjectStatus(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_ProjStatus_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetProjectType(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_Proj_Status_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetProjectCat(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_ProjCat_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetTimesheet(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimeSheet_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetCIGroup(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_CIG_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetPracType(int parentId)
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_PracType_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@parentId", DbType.Int32);
            param[0].Value = parentId;

            cmd.Parameters.AddRange(param);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                SelectListNew.Add(new SelectList
                {
                    Id = Convert.ToInt32(dr["KeyID"]),
                    Name = Convert.ToString(dr["KeyName"])
                });
            }
            return SelectListNew;
        }
        public List<SelectList> GetRecruiter()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_ActualRec_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["Full_Name"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<SelectList> GetLocation()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_Location_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["LOCATION_ID"]), Name = reader["LOCATION_NAME"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<SelectList> GetSubDomain()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_SubDomain_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["KeyId"]), Name = reader["KeyName"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<SelectList> GetTimeSheetRep()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_TimesheetRep_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["FullName"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<SelectList> GetSalesPerson()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_SalesPerson_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["EmployeeDetails_Id"]), Name = reader["SalesPerson"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<SelectList> GetPayRoll()
        {
            List<SelectList> SelectListNew = new List<SelectList>();

            Connection();
            SqlCommand cmd = new SqlCommand("Get_PayRoll_Training_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                SelectListNew.Add(new SelectList { Id = Convert.ToInt32(reader["State_Id"]), Name = reader["Payroll_State"].ToString() });
            }

            reader.Close();

            con.Close();
            return SelectListNew;
        }
        public List<Project> GetProjectsList()
        {
            DataSet ds = new DataSet();
            List<Project> SelectListNew = new List<Project>();
            Connection();
            SqlCommand cmd = new SqlCommand("All_ProjectDetails_Kailash", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }
            if(ds.Tables.Count>0)
            {
                for (int i=0; i<ds.Tables[0].Rows.Count; i++)
                {
                    Project obj = new Project();
                    obj.Cust_Name = Convert.ToString(ds.Tables[0].Rows[i]["Cust_Name"]);
                    obj.Project_Name = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Name"]);
                    obj.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["Proj_Id"]);
                    obj.SD = Convert.ToString(ds.Tables[0].Rows[i]["Start_Date"]);
                    obj.ED = Convert.ToString(ds.Tables[0].Rows[i]["End_Date"]);
                    obj.Project_Status = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Status"]);
                    obj.Location_Group = Convert.ToString(ds.Tables[0].Rows[i]["Loc_Group"]);
                    obj.PayRoll_State = Convert.ToString(ds.Tables[0].Rows[i]["PayRoll"]);
                    obj.Sales_Person = Convert.ToString(ds.Tables[0].Rows[i]["SalesPerson"]);
                    obj.Proj_Cat = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Cat"]);
                    obj.Proj_Type = Convert.ToString(ds.Tables[0].Rows[i]["Proj_Type"]);
                    obj.Sub_Dom = Convert.ToString(ds.Tables[0].Rows[i]["Sub_Domain"]);
                    obj.TSP= Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetRep"]);
                    obj.CIG = Convert.ToString(ds.Tables[0].Rows[i]["CLientInvoice"]);
                    obj.TimesheetType = Convert.ToString(ds.Tables[0].Rows[i]["TimeSheetType"]);
                    obj.IVT = Convert.ToString(ds.Tables[0].Rows[i]["IsVMS"]);
                    obj.Prac_Type= Convert.ToString(ds.Tables[0].Rows[i]["Prac_Type"]);
                    obj.Recruiter = Convert.ToString(ds.Tables[0].Rows[i]["Recruiter"]);
                    SelectListNew.Add(obj);
                }
            }
            return SelectListNew;
        }
    }
}