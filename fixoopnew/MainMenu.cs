using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fixoopnew
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=fixoop";
            MySqlConnection mySqlCon = new MySqlConnection(MyConnection2);
            MySqlCommand mySqlCmd = mySqlCon.CreateCommand();


            mySqlCmd.CommandText = "SELECT count(id) FROM bodypart";
            mySqlCon.Open();
            int returnValue = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_bodypart.Text = returnValue.ToString();

            mySqlCmd.CommandText = "SELECT count(id) FROM branch";
            int returnValue2 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue2 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_branch.Text = returnValue2.ToString();

            mySqlCmd.CommandText = "SELECT count(id) FROM delivery";
            int returnValue3 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue3 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_delivery.Text = returnValue3.ToString();

            mySqlCon.Close();
        }
            private void lbl_bodypart_Click(object sender, EventArgs e)
        {

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            //โค๊ดเชื่อมต่อ
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=fixoop";
            MySqlConnection mySqlCon = new MySqlConnection(MyConnection2);
            MySqlCommand mySqlCmd = mySqlCon.CreateCommand();

            //โค๊ดอัพเดทตัวเลข
            mySqlCmd.CommandText = "SELECT count(id) FROM bodypart";
            mySqlCon.Open();
            int returnValue = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_bodypart.Text = returnValue.ToString();


            mySqlCmd.CommandText = "SELECT count(id) FROM branch";
            int returnValue2 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue2 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_branch.Text = returnValue2.ToString();

            //โค๊ดอัพเดทตัวเลข
            mySqlCmd.CommandText = "SELECT count(id) FROM delivery";
            int returnValue3 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            returnValue3 = int.Parse(mySqlCmd.ExecuteScalar().ToString());
            lbl_delivery.Text = returnValue3.ToString();

            mySqlCon.Close();
        }
    }
}
