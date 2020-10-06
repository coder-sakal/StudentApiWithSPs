using Microsoft.Ajax.Utilities;
using StudentApiWithSPs.CustomAttributes;
using StudentApiWithSPs.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace StudentApiWithSPs.DAL
{
    public static class ADOHelper
    {

        public static object Save(this Base b)
        {

            string ConnectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                var spName=((SPName)b.GetType().GetCustomAttributes().Where(a => a is SPName).SingleOrDefault()).Name;
                //Create the SqlCommand object
                SqlCommand cmd = new SqlCommand(spName, con);
                //Specify that the SqlCommand is a stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                PropertyInfo[] properties = b.GetType().GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    var paramName = ((ParamterName)properties[i].GetCustomAttributes().Where(a => a is ParamterName).SingleOrDefault()).Name;
                    var value = properties[i].GetValue(b);
                    cmd.Parameters.AddWithValue(paramName, value);
                }                
          

                //Add the output parameter to the command object
                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@Error";
                outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outPutParameter);

                //Open the connection and execute the query
                con.Open();
                cmd.ExecuteNonQuery();

                //Retrieve the value of the output parameter
                string Error = outPutParameter.Value.ToString();
                return Error;
            }
        }
    }
}