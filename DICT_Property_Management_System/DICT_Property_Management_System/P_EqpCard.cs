using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace DICT_Property_Management_System
{
    class P_EqpCard
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
        //Card Show
        public void ctblshow (ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0));
                tbli.SubItems.Add(dr.GetString(2));
                tbli.SubItems.Add(dr.GetString(1));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        public string ctblshow()
        {
            string cid="0";
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                cid = dr.GetString(0);
            }
            dr.Dispose();
            dbclose();
            return cid;
        }
        //Card Generate
        public void cgen(string cd1,string cd2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardgen", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("cdate", cd2);
            pms_cmd.Parameters.AddWithValue("name", cd1);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Card Edit
        public void cedit(string cpk,string cd1, string cd2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardedit", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("cname",cd1);
            pms_cmd.Parameters.AddWithValue("caid",cpk);
            pms_cmd.Parameters.AddWithValue("cdate", cd2);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Card Delete
        public void cdelete(string cpk)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcarddelete", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@caid", cpk);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        
        //Log Add
        public void logadd(string ld2, string ld3, string ld4, string ld5, string ld6,string ld7)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqplogadd", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("ldate", ld2);
            pms_cmd.Parameters.AddWithValue("mrt", ld3);
            pms_cmd.Parameters.AddWithValue("inv", ld4);
            pms_cmd.Parameters.AddWithValue("rem", ld5);
            pms_cmd.Parameters.AddWithValue("stat", ld6);
            pms_cmd.Parameters.AddWithValue("bal", ld7);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Log Remove Current
        public void logcurset(string ld1)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqplogcurrreset", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("invno", ld1);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Log Show
        public void logtblshow(ListView tbl,string inv)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpindlogshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("invno", inv);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(1));
                tbli.SubItems.Add(dr.GetString(2));
                tbli.SubItems.Add(dr.GetString(4));
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
        public string logtblshow(string inv)
        {
            pms_sql.Open();
            string id="";
            pms_cmd = new MySqlCommand("eqpindlogshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("invno", inv);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr.GetString(0);
            }
            dr.Dispose();
            dbclose();
            return id;
        }
        public bool logtblshow(string inv,int i)
        {
            pms_sql.Open();
            string check="";
            pms_cmd = new MySqlCommand("eqpindlogshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("invno", inv);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                check = dr.GetString(5);
            }           
            dr.Dispose();
            dbclose();
            if (check == "RETURN")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string loggetprevmr(string inv)
        {
            pms_sql.Open();
            string mr = "";
            pms_cmd = new MySqlCommand("eqpindlogshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("invno", inv);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            while (dr.Read())
            {
                mr = dr.GetString(2);
            }
            dr.Dispose();
            dbclose();
            return mr;
        }
        //Link Add
        public void linkadd(string cd1, string cd2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("linkcardlogadd", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("cardid", cd1);
            pms_cmd.Parameters.AddWithValue("invno", cd2);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Card View
        public void cshow(ListView tbl, string caid) { 
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardview", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("cardid",caid);
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            string totalbal="";
            string totalquan="";
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem(dr.GetString(0));
                if (dr.GetString(8)=="Current")
                {
                    tbli.ForeColor = System.Drawing.Color.Green;
                }
                if (dr.GetString(9) == "DISPOSAL")
                {
                    tbli.ForeColor = System.Drawing.Color.Red;
                }
                for (int x = 1;x<=7;x++)
                {   
                    if (x==1||x==2)
                    {
                        if(dr.GetString(x)!="")
                        {
                            float c = float.Parse(dr.GetString(x));
                            string cur = "";
                            if (dr.GetString(9)=="DISPOSAL"&& x==1)
                            {
                                cur = String.Concat("-₱ ", c.ToString("F"));
                            }
                            else
                            {
                                cur = String.Concat("₱ ", c.ToString("F"));
                            }                          
                            tbli.SubItems.Add(cur);
                        }
                        else
                        {
                            tbli.SubItems.Add(dr.GetString(x));
                        }
                    }
                    else
                    {
                        tbli.SubItems.Add(dr.GetString(x));
                    }                                     
                }
                totalbal = dr.GetString(2);
                totalquan = dr.GetString(4);
                tbl.Items.Add(tbli);
            }
            tbl.Items.Add("");
            ListViewItem tbli1 = new ListViewItem("");
            tbli1.SubItems.Add("Total:");
            float d = float.Parse(totalbal);
            string cur1 = String.Concat("₱ ", d.ToString("F"));
            tbli1.SubItems.Add(cur1);
            tbli1.SubItems.Add("Total:");
            tbli1.SubItems.Add(totalquan);
            tbl.Items.Add(tbli1);
            dr.Dispose();
            dbclose();
        }
        //Log Disposal Delete
        public void logdispodel(string id)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcarddispdel", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@piid", id);           
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Log Balance Change 
        public void logbalchange(string lgd1,string lgd2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqplogbalchange", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@invid", lgd1);
            pms_cmd.Parameters.AddWithValue("@cost", lgd2);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
        //Log Set Current
        public void logsetcurr(string lgid)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("eqpcardsetcurr", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            pms_cmd.Parameters.AddWithValue("@lid", lgid);
            pms_cmd.ExecuteNonQuery();
            dbclose();
        }
    }
}
