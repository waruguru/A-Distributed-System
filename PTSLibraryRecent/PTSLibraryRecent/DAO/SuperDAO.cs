﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace PTSLibraryRecent.DAO
{
   public class SuperDAO
    {
        protected Customer GetCustomer(int custId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            Customer cust;
            sql = "SELECT * FROM Customer WHERE CustomerId = " + custId;
            cn = new SqlConnection(Properties.Settings.Default.wm75ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                dr.Read();
                cust = new Customer(dr["Name"].ToString(), (int)dr["CustomerId"]);
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting Customer", ex);
            }
            finally
            {
                cn.Close();
            }
            return cust;
        }
        public List<Task> GetListOfTasks(Guid projectId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<Task> tasks;
            tasks = new List<Task>();
            sql = "SELECT * FROM Task WHERE ProjectId = '" + projectId + "'";
            cn = new SqlConnection(Properties.Settings.Default.wm75ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Task t = new Task((Guid)dr["TaskId"], dr["Name"].ToString(),
                    (Status)((int)dr["StatusId"]));
                    tasks.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting taks list", ex);
            }
            finally
            {
                cn.Close();
            }
            return tasks;
        }
    }
}