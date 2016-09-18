using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MyInformation.Models;

namespace MyInformation.Repository
{
    public class EmpRepository
    {
        private SqlConnection con;

        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["AddNewEmpDetails"].ToString();
            con = new SqlConnection(constr);
        }

        public bool AddEmp(Employee obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.Age);
            com.Parameters.AddWithValue("@Address", obj.Gender);
          
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }


        }
        
    }
}