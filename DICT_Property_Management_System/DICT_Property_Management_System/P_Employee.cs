using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_Employee
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
        //Employee Table Show
        public void empshow(ListView tbl,int sel)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("emptblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                if (sel > 0)
                {
                    ListViewItem tbli = new ListViewItem(dr.GetString(0).ToString());
                    tbli.SubItems.Add(dr.GetString(1));
                    tbl.Items.Add(tbli);
                }
                else
                {
                    ListViewItem tbli = new ListViewItem(dr.GetString(1));
                    tbli.SubItems.Add(dr.GetString(0).ToString());
                    tbl.Items.Add(tbli);
                }
                
            }
            dr.Dispose();
            dbclose();
        }
        public void empshow(ComboBox ins)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("emptblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();            
            while (dr.Read())
            {
                ins.Items.Add(String.Concat(dr.GetString(0), "-", dr.GetString(1)));   
            }
            dr.Dispose();
            dbclose();
        }
        //Employee Add
        public void empadd(string ec1,string ec2,string ec3,string ec4,string ec5,string ec6)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empadd", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@name", ec1);
            pms_cmd.Parameters.AddWithValue("@cont", ec2);
            pms_cmd.Parameters.AddWithValue("@email", ec3);
            pms_cmd.Parameters.AddWithValue("@piclink", ec4);
            pms_cmd.Parameters.AddWithValue("@jobt", ec5);
            pms_cmd.Parameters.AddWithValue("@dept", ec6);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Employee Select
        public void empselected(string id,string[] db)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empselectemp", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@eid", id);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            db[0] = dr.GetString(1);
            db[1] = dr.GetString(2);
            db[2] = dr.GetString(3);
            db[3] = dr.GetString(4);
            db[4] = dr.GetString(5);
            db[5] = dr.GetString(6);
            dr.Dispose();
            dbclose();
        }
        //Employee Edit 
        public void empedit(string ec1, string ec2, string ec3, string ec4,string ec5,string ec6,string emp)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empedit", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@name", ec1);
            pms_cmd.Parameters.AddWithValue("@cont", ec2);
            pms_cmd.Parameters.AddWithValue("@email", ec3);
            pms_cmd.Parameters.AddWithValue("@piclink", ec4);
            pms_cmd.Parameters.AddWithValue("@empid", emp);
            pms_cmd.Parameters.AddWithValue("@jobt", ec5);
            pms_cmd.Parameters.AddWithValue("@dept", ec6);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Employee Delete
        public bool empdelete(string emp)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empdelete", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;           
            pms_cmd.Parameters.AddWithValue("@empid", emp);
            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pms_cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted", "Successful Deletion!");
                dbclose();
                return true;              
            }       
            else
            {
                dbclose();
                return false;
            }                              
        }
        //Employee Label Show
        public string emplblshow(string emp)
        {
            pms_sql.Open();
            string outstring = "";
            pms_cmd = new MySqlCommand("emplblshow", pms_sql);
            pms_cmd.Parameters.AddWithValue("@empid", emp);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                outstring = String.Concat(dr.GetString(0), "-", dr.GetString(1));
            }
            dr.Dispose();
            dbclose();
            return outstring;
        }
        //Linked Employee Table
        public void empinvlink(ListView tbl,string emp)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empinvlink", pms_sql);
            pms_cmd.Parameters.AddWithValue("@empid", emp);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0));
                tbli.SubItems.Add(dr.GetString(1));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        public bool empinvlink(string emp)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("empinvlink", pms_sql);
            pms_cmd.Parameters.AddWithValue("@empid", emp);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Dispose();
                dbclose();
                return true;
            }
            else
            {
                dr.Dispose();
                dbclose();
                return false;
            }           
        }
    }
}
