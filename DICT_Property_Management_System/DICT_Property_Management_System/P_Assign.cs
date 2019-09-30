using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_Assign
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
        //Assign property table show
        public void asishow(ListView tbl)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("assigntblshow", pms_sql);
            pms_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            MySqlDataReader dr = pms_cmd.ExecuteReader();
            tbl.Items.Clear();
            while (dr.Read())
            {
                ListViewItem tbli = new ListViewItem();
                if (dr.GetString(3) == "1" && dr.GetString(4) == "1")
                {
                    tbli.ForeColor = System.Drawing.Color.Green;
                }
                tbli.SubItems.Add(dr.GetString(0));
                for (int x = 1;x<=4;x++)
                {
                    tbli.SubItems.Add(dr.GetString(x));
                }
                tbl.Items.Add(tbli);
            }
            dr.Dispose();
            dbclose();
        }
    }
}
