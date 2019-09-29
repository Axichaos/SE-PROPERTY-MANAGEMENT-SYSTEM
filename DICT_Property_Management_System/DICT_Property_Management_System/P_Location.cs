using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace DICT_Property_Management_System
{
    class P_Location
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
        //Location Table Show
        public void locshow(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("loctblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0).ToString());
                for (int x = 1; x <= 3; x++)
                {
                    tbli.SubItems.Add(dr.GetString(x));
                }
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        public void loclblins(ComboBox cbo)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("loctblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo.Items.Add(String.Concat(dr.GetString(0),"-",dr.GetString(1),"-",dr.GetString(3)));
            }
            dr.Dispose();
            dbclose();
        }
        public String loclblins(string id)
        {
            pms_sql.Open();
            string outstring="";
            pms_cmd = new MySqlCommand("loclblshow", pms_sql);
            pms_cmd.Parameters.AddWithValue("@locid", id);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            outstring = String.Concat(dr.GetString(0), "-", dr.GetString(1), "-", dr.GetString(3));
            dr.Dispose();
            dbclose();
            return outstring;
        }
        //Location Add
        public void locadd(string lc1,string lc2,string lc3)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locadd", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@loc", lc1);
            pms_cmd.Parameters.AddWithValue("@pro", lc2);
            pms_cmd.Parameters.AddWithValue("@room", lc3);
            pms_cmd.ExecuteNonQuery();       
            dbclose();
        }
        //Location Edit Information
        public void loceditinfo(string lc1,string[] str)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("loceditret", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@locid", lc1);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            str[0] = dr.GetString(1);
            str[1] = dr.GetString(2);
            str[2] = dr.GetString(3);
            dr.Dispose();
            dbclose();
        }
        //Location Edit
        public void locedit(string lc1, string lc2, string lc3,string id)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locedit", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@loc", lc1);
            pms_cmd.Parameters.AddWithValue("@prov", lc2);
            pms_cmd.Parameters.AddWithValue("@room", lc3);
            pms_cmd.Parameters.AddWithValue("@locid", id);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Location Delete
        public void locdelete(string id)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locdelete", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@locid", id);
            if (MessageBox.Show("Are you sure you want to delete this location?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pms_cmd.ExecuteNonQuery();
                MessageBox.Show("Location Deleted", "Successful Deletion!");
            }
            dbclose();
        }
        //List Locations
        public void loclist(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locselectloc", pms_sql);
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
        //Inventory Linked With Location
        public void loclistinvtoloc(ListView tbl,string id)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locinvonloc", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@locid", id);
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
        public bool loclistinvtoloc(string id)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locinvonloc", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@locid", id);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            if(dr.Read())
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
        //Inventory Linked With Province
        public void loclistinvtoprov(ListView tbl, string pro)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("locinvonprov", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@prov", pro);
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
    }
}
