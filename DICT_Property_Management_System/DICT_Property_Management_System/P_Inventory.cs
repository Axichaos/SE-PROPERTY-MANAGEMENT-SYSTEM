using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_Inventory
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
        //Inventory Show
        public void invshow(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invshowout", pms_sql);
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
        public void invshowlog(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invshowout1", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0).ToString());
                tbli.SubItems.Add(dr.GetString(1));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        public void invshowall(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invshowout2", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0).ToString());
                tbli.SubItems.Add(dr.GetString(1));
                tbli.SubItems.Add(dr.GetString(7));
                tbli.SubItems.Add(dr.GetString(9));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        //Inventory Show Details
        public void invshowd(string invid,string[] lblarr)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invshowd", pms_sql);
            pms_cmd.Parameters.AddWithValue("@invno", invid);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int x = 0; x <= 17; x++)
                {
                    if (x==13)
                    {
                        lblarr[x] = "0";
                    }
                    else
                    {
                        lblarr[x] = dr.GetString(x);
                    }
                }
            }
            dr.Dispose();
            dbclose();
        }
        //Inventory Add
        public void invadd(string pc1,string pc2,string pc3,string pc4,string pc5,string pc6,string pc7,string pc8,string pc9, string pc10, string pc11, string pc12,string pc13,string pc14,string pc15,string pc16)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invadd", pms_sql);
            pms_cmd.Parameters.AddWithValue("@inv", pc1);
            pms_cmd.Parameters.AddWithValue("@name", pc2);
            pms_cmd.Parameters.AddWithValue("@un",pc3);
            pms_cmd.Parameters.AddWithValue("@typ",pc4);
            pms_cmd.Parameters.AddWithValue("@rem",pc5);
            pms_cmd.Parameters.AddWithValue("@art",pc6);
            pms_cmd.Parameters.AddWithValue("@co",pc7);
            pms_cmd.Parameters.AddWithValue("@des",pc8);
            pms_cmd.Parameters.AddWithValue("@locid",pc9);
            pms_cmd.Parameters.AddWithValue("@serial",pc10);
            pms_cmd.Parameters.AddWithValue("@accpid",pc11);
            pms_cmd.Parameters.AddWithValue("@accc",pc12);
            pms_cmd.Parameters.AddWithValue("@sign", pc13);
            pms_cmd.Parameters.AddWithValue("@rct", pc14);
            pms_cmd.Parameters.AddWithValue("@rci", pc15);
            pms_cmd.Parameters.AddWithValue("@dateacq", pc16);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Inventory Update
        public void invupdate(string pck, string pc2, string pc3, string pc4, string pc5, string pc6, string pc7, string pc8, string pc10, string pc12, string pc13, string pc14, string pc15, string pc16)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invupdate", pms_sql);
            pms_cmd.Parameters.AddWithValue("@pk", pck);
            pms_cmd.Parameters.AddWithValue("@name", pc2);
            pms_cmd.Parameters.AddWithValue("@un", pc3);
            pms_cmd.Parameters.AddWithValue("@typ", pc4);
            pms_cmd.Parameters.AddWithValue("@rem", pc5);
            pms_cmd.Parameters.AddWithValue("@art", pc6);
            pms_cmd.Parameters.AddWithValue("@co", pc7);
            pms_cmd.Parameters.AddWithValue("@des", pc8);
            pms_cmd.Parameters.AddWithValue("@serial", pc10);
            pms_cmd.Parameters.AddWithValue("@accc", pc12);
            pms_cmd.Parameters.AddWithValue("@sign", pc13);
            pms_cmd.Parameters.AddWithValue("@rct", pc14);
            pms_cmd.Parameters.AddWithValue("@rci", pc15);
            pms_cmd.Parameters.AddWithValue("@dateacq", pc16);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Inventory Delete  
        public void invdelete(string pck)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invdelete", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@pk",pck);
            if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pms_cmd.ExecuteNonQuery();
                MessageBox.Show("Entry Deleted", "Successful Deletion!");
            }
            dbclose();
        }
        //Transfer to Disposal
        public void intodi(string pc1,string pc2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invtodispo", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@pk", pc1);
            pms_cmd.Parameters.AddWithValue("@dpk", pc2);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Disposal To Inventory
        public void ditoin(string pc1)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("disptoin", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@invno", pc1);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Retirieve MR
        public string invretmr(string dd1,int i)
        {
            string mr1;
            string mr2;
            string mr3;
            pms_sql.Open();
            pms_cmd = new MySqlCommand("invretmr", pms_sql);
            pms_cmd.Parameters.AddWithValue("@invno", dd1);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            dr.Read();
            mr1 = dr.GetString(0);
            mr2 = dr.GetString(1);
            mr3 = dr.GetString(2);
            dr.Dispose();
            dbclose();
            if (i == 1)
            {
                return mr1;
            }
            else if (i==2)
            {
                return mr2;
            }
            else
            {
                return mr3;
            }
        }
    }
}
