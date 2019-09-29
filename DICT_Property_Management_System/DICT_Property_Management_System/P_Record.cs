using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_Record
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
        //Record Show
        public void recordshow(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetInt32(0).ToString());
                for (int x = 1; x <= 6; x++)
                {
                    if(dr.IsDBNull(x))
                    {
                        tbli.SubItems.Add("0");
                    }
                    else
                    {
                        if (x==2)
                        {
                            float c = float.Parse(dr.GetString(2));
                            string temp = String.Concat("₱", c.ToString("F"));
                            tbli.SubItems.Add(temp);
                        }
                        else
                        {
                            tbli.SubItems.Add(dr.GetString(x));
                        }                      
                    }      
                    
                }
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        //Record Inventory Show
        public void recordinvshow(string rpk,ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recinvshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@rpk", rpk);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetInt32(0).ToString());
                if (String.Equals(dr.GetString(3), "DISPOSED"))
                {
                    tbli.ForeColor = System.Drawing.Color.Red;
                }
                for (int x = 1; x <= 2; x++)
                {
                    if (x == 2)
                    {
                        float c = float.Parse(dr.GetString(2));
                        string temp = String.Concat("₱", c.ToString("F"));
                        tbli.SubItems.Add(temp);
                    }
                    else
                    {
                        tbli.SubItems.Add(dr.GetString(x));
                    }
                }               
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        //Record Add
        public void recordadd(string rc1,string rc2,string rc3,string rc4)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recadd", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@sign", rc1);
            pms_cmd.Parameters.AddWithValue("@rt", rc2);
            pms_cmd.Parameters.AddWithValue("@iss", rc3);
            pms_cmd.Parameters.AddWithValue("@da", rc4);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Record ID Add
        public void recordidadd(ComboBox cbo)
        {
            cbo.Items.Clear();
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recidshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                cbo.Items.Add(dr.GetString(0));
                cbo.Text = (dr.GetString(0));
            }
            dr.Dispose();
            dbclose();
        }    
        //Record Edit
        public void receditret(string rpk,string[] lblrarr)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("receditret", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@rpk", rpk);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int x=0;x<=4; x++)
                {
                    lblrarr[x] = dr.GetString(x);
                }
            }
            dr.Dispose();
            dbclose();
        }
        public void recedit(string id,string rc1,string rc2,string rc3,string rc4)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recupdate", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@prpk", id);
            pms_cmd.Parameters.AddWithValue("@sign", rc1);
            pms_cmd.Parameters.AddWithValue("@rt", rc2);
            pms_cmd.Parameters.AddWithValue("@iss", rc3);
            pms_cmd.Parameters.AddWithValue("@da", rc4);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Record Delete
        public void recdelete(string rcpk)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("recdelchild", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@rpk", rcpk);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            if(dr.Read())
            {
                string lbl = dr.GetString(0);
                dr.Dispose();
                if (MessageBox.Show("Deleting this entry will cause "+lbl+" child entries to be deleted! Are you sure?","Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pms_cmd = new MySqlCommand("recdelete", pms_sql);
                    pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    pms_cmd.Parameters.AddWithValue("@rcpk", rcpk);
                    pms_cmd.ExecuteNonQuery();
                }
            }
            dbclose();
        }
    }
}
