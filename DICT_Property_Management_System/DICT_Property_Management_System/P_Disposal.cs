using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_Disposal
    {
        //Starting Variables
        static string pms_con = "datasource=localhost;port=3306;Database=propertymanagementdb;username=root;password=;";
        MySqlConnection pms_sql = new MySqlConnection(pms_con);
        MySqlCommand pms_cmd;
        public void dbclose()
        {
            pms_cmd.Dispose();
            pms_sql.Close();
        }
        //Disposal Generate
        public void dispgen(string dd1, string dd2, string dd3, string dd4)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("dispgen", pms_sql);
            pms_cmd.Parameters.AddWithValue("@invno", dd1);
            pms_cmd.Parameters.AddWithValue("@ddate",dd2);
            pms_cmd.Parameters.AddWithValue("@dmeth", dd3);
            pms_cmd.Parameters.AddWithValue("@dremark",dd4);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Disposal ID Retrieve
        public string dispidget(string dd1)
        {
            string id = "";
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invdispid", pms_sql);
            pms_cmd.Parameters.AddWithValue("invno", dd1);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            id = dr.GetString(0);
            dr.Dispose();
            dbclose();
            return id;
        }
        //Disposal Table Show
        public void disptblshow(ListView tbl)
        {
            pms_sql.Open();
            tbl.Items.Clear();
            pms_cmd = new MySqlCommand("disptblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetInt32(0).ToString());
                tbli.SubItems.Add(dr.GetString(1));
                tbli.SubItems.Add(dr.GetString(2));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        //Disposal Label Show
        public void displblshow(string dd1,Label dl1, Label dl2, TextBox dt1)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("displbl", pms_sql);
            pms_cmd.Parameters.AddWithValue("@did", dd1);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            dl1.Text = dr.GetString(0);
            dl2.Text = dr.GetString(1);
            dt1.Text = dr.GetString(2);
            dr.Dispose();
            dbclose();
        }
        public void displblshow(string dd1, string[] dets)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("displbl", pms_sql);
            pms_cmd.Parameters.AddWithValue("@did", dd1);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            for (int x = 0;x <= 2;x++)
            {
                dets[x] = dr.GetString(x);
            }
            dr.Dispose();
            dbclose();
        }
        //Disposal Edit
        public void dispedit(string dd1, string dd2, string dd3, string dd4)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("dispedit", pms_sql);
            pms_cmd.Parameters.AddWithValue("@did", dd1);
            pms_cmd.Parameters.AddWithValue("@ddate", dd2);
            pms_cmd.Parameters.AddWithValue("@dmeth", dd3);
            pms_cmd.Parameters.AddWithValue("@drem", dd4);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Disposal Delete
        public void dispdelete(string dd1)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("dispdelete", pms_sql);
            pms_cmd.Parameters.AddWithValue("@did", dd1);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;   
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
    }
}
