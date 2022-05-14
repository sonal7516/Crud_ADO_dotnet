using Crud_ADO_dotnet.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace Crud_ADO_dotnet.Models
{
    public class DepartmentDB
    {
        private DBConfig db = new DBConfig();
        public List<Department> GetAllDepartment()
        {
            SqlCommand cmd = new SqlCommand("SP_Department", db.sql);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter.ParameterName = "@action";
            sqlParameter.Value = "Select";
            sqlParameter.DbType = DbType.String;
            cmd.Parameters.Add(sqlParameter);

            if (db.sql.State == ConnectionState.Closed)
                db.sql.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Department> departmentList = new List<Department>();
            while (reader.Read())
            {
                Department dept = new Department();
                dept.ID = (int)reader[0];
                dept.Name = reader[1].ToString();
                departmentList.Add(dept);
            }

            db.sql.Close();
            return departmentList;
        }
    }
}