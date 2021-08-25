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
        public IList<Project> GetProjectsList()
        {
            IList<Project> SelectListNew = new List<Project>();

            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Project_View_Kailash", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                }
                con.Close();
            }
            return SelectListNew;
        }
    }
}