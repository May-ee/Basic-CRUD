using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BasicCRUDMohammad
{
    public partial class LogIn : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;

        public LogIn()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\WORKS TO BE PASSED\\Info MGT\\BasicCRUDMohammad\\BasicCRUD.accdb";

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            try { 
            conn.Open();
          //cmd.Connection = conn;
            string query = "SELECT * FROM users WHERE username LIKE '"+ usernamebox.Text +"' AND password LIKE '"+ userpassbox.Text +"'  ";
            cmd = new OleDbCommand(query, conn);

            reader = cmd.ExecuteReader();

            int count = 0;

            while (reader.Read())
            {
                count = count + 1;  
            }

            if (count == 1)
            {
                MessageBox.Show("Welcome User", "Log In Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                LandForm frm = new LandForm();
                frm.ShowDialog();
                    conn.Close();
                }
            else
            {
                MessageBox.Show("Invalid Credientials", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
            }
            conn.Close();
            this.Dispose();


            } catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void logcancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginbtn_Click((object)sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                logcancel_Click((object)sender, e);
            }
        }

        
    }
}
