using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DALL;
namespace BO
{
    public class Operations
    {
        public DBconnection conn = new DBconnection();
        public receive recv = new receive();

        bool status = false;

        public int InsertReginfo(receive recv)   
                           
        {
             
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO reginfo VALUES ('" + recv.name + "','" + recv.pass + "','" + recv.type + "','" + recv.createat + "','" + recv.imageBt + "','" + recv.addrs + "','" + recv.phn + "','" + recv.status + "')";
            return conn.ExeNonQuery(cmd);
        }

        public DataTable login(receive recv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from reginfo where username= '"+recv.name+"' and pass= '"+recv.pass+"'";
            return conn.ExeReader(cmd);
        }

        public void AutogenerateState()
        {
            Autogenerate aut1 = new Autogenerate();
            bool i =Convert.ToBoolean(aut1.AutogenerateId("reginfo"));
            status = i;
        }


        public int InsertIttpes(receive recv)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO masterItem VALUES ('" + recv.itno + "','" + recv.itypes + "')";
            return conn.ExeNonQuery(cmd);
        }

        public int InsertItems(receive recv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO items VALUES('" + recv.ino + "','" + recv.iname + "','" + recv.qty + "','" + recv.price + "','" + recv.ityno + "')";
            return conn.ExeNonQuery(cmd);
        }

        public string InsertItemsNo(receive recv, receive recv1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT recv.ino from masterItem WHERE recv.itypes = 'recv1.itypes'";
            return cmd.CommandText;
        }

        public DataTable ViewItemTypes(receive recv)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM masterItem;";
           // SqlDataReader myReader;
            return conn.ExeReader(cmd);
            //try
           // {
                //myReader = cmd.ExecuteReader();
                //while (myReader.Read())
               // {
                    //string sname = myReader.GetString("");
               // }
            }
                          
            //catch(Exception){}
            
        }
    }

