using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DICT_Property_Management_System
{
    class P_User
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
        //Login Check
        public bool logincheck(string ud1,string ud2)
        {
            pms_sql.Open();
            pms_cmd = new MySqlCommand("acccheck", pms_sql);
            pms_cmd.Parameters.AddWithValue("@un", ud1);
            pms_cmd.Parameters.AddWithValue("@pass", ud2);
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
                MessageBox.Show("Username/Password is incorrect!", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
