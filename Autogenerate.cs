using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using DALL;


namespace BO
{
  
   public class Autogenerate
   {
 
       public int AutogenerateId(string tablename)
       {
           try{
               String connString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=FoodCourtDB;Integrated Security=True";
               SqlConnection conn = new SqlConnection(connString);

               //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ToString());
               //con.Open();

               if (conn.State == ConnectionState.Closed)
               {
                   conn.Open();
               }
              // return conn;


               SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM"+tablename, conn);
               int i = Convert.ToInt32(cmd.ExecuteScalar());
               i++;
               return i;
               
           }
           //catch (NullReferenceException nre)
           catch(Exception ex)
           {
               //MessageBox.Show("\nCan't read AutogenerateId, auto is null.\n" + nre.Message);
               MessageBox.Show(ex.Message);
            }
            return 0;
            
           }
       }   
    }
  

