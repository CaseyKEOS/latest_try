using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using XamppTry.View;

namespace XamppTry
{
    public class database
    {
        string dbconnection = "datasource=127.0.0.1; port=3306; username=root; password=; database=xampptry;";
        MySqlConnection con;
        MySqlCommand cmd;
        string query;
        public database()
        {
            con = new MySqlConnection(dbconnection);
        }

        public void save(string name, string email, string phone, string message) 
        { 
            con.Open();
            query = "INSERT INTO tblcontact (name, email, phone, message) VALUES ('" + name + "', '" + email + "', '" + phone + "', '" + message + "')";
            cmd = new MySqlCommand(query, con); 
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void register(string name, string password, string age)
        {
            con.Open();
            query = "INSERT INTO tbluser (name, password, gender) VALUES ('" + name + "', '" + password + "', '" + age + "')";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ViewList(GridView list, string sql)
        {
            con.Open(); 
            cmd = new MySqlCommand(sql, con);   

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);

            list.DataSource = data;
            list.DataBind();
            con.Close();
        }

        public void populate(DropDownList list, string sql)
        {
            con.Open();
            cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);

            list.DataSource = data;
            list.DataTextField = "id";
            list.DataBind();
            con.Close();
        }

        public void saveupd(string id, string name, string email, string phone, string message)
        {
            con.Open();
            cmd = new MySqlCommand("SELECT id FROM tblcontact WHERE id = '" + id + "'", con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            if(data.Rows.Count > 0){

                query = "UPDATE tblcontact SET name = '" + name + "', email = '" + email + "', phone= '" + phone + "', message= '" + message + "' WHERE id ='"+id+ "'";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                query = "INSERT INTO tblcontact (name, email, phone, message) VALUES ('" + name + "', '" + email + "', '" + phone + "', '" + message + "')";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            
            con.Close();
        }
        public void delete(string id)
        {
            con.Open();
            cmd = new MySqlCommand("SELECT id FROM tblcontact WHERE id = '" + id + "'", con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable data = new DataTable();
            adapter.Fill(data);
            query = "DELETE FROM tblcontact WHERE id ='" + id + "'";
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}