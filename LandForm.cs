using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BasicCRUDMohammad
{
    public partial class LandForm : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private OleDbDataAdapter adapter;
        private DataTable dt;


        public LandForm()
        {
            InitializeComponent();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\WORKS TO BE PASSED\\Info MGT\\BasicCRUDMohammad\\BasicCRUD.accdb";

        }

        private void LandForm_Load(object sender, EventArgs e)
        {
            // GetStudents();
            getstudents();
        }

        private void getstudents()
        {

            try
            {
                conn.Open();
                string query = "SELECT * FROM students";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }



        private void ClearForm()
        {
            edpbox.Text = "";
            namebox.Text = "";
            agebox.Text = "";
         //   dobpicker.Text = "";
            coursebox.Text = "";
            deptbox.Text = "";
        }


        private void btnaddsavestud_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();

                string query = "INSERT INTO students (EDP, Name, Age, Course, Department) VALUES (Edp, Name, Age, Course , Dept)";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("Edp", int.Parse(edpbox.Text));
                cmd.Parameters.AddWithValue("Name", namebox.Text);
                cmd.Parameters.AddWithValue("Age", agebox.Text);
             //cmd.Parameters.AddWithValue("Bday", dobpicker.Text);
                cmd.Parameters.AddWithValue("Course", coursebox.Text);
                cmd.Parameters.AddWithValue("Dept", deptbox.Text);

                cmd.ExecuteNonQuery();
                conn.Close();


                MessageBox.Show("Student Record Added", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                getstudents();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            conn.Close();
        }

        private void btnupdatestud_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                string query = "UPDATE students SET Name = @Name, Age = @Age, Course = @Course, Department = @Dept WHERE EDP = @Edp";
                cmd = new OleDbCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@Name", namebox.Text);
                cmd.Parameters.AddWithValue("@Age", agebox.Text);
              //cmd.Parameters.AddWithValue("Bday", dobpicker.Text);
                cmd.Parameters.AddWithValue("@Course", coursebox.Text);
                cmd.Parameters.AddWithValue("@Dept", deptbox.Text);
                cmd.Parameters.AddWithValue("@Edp", int.Parse(edpbox.Text));

                cmd.ExecuteNonQuery();

                
                MessageBox.Show("Student Record Updated", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                getstudents();
                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            conn.Close();
            

        }

        private void btndeletestud_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();

                string query = "DELETE * FROM students WHERE EDP = @Edp";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Edp", int.Parse(edpbox.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Student Record Deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getstudents();
                ClearForm();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error" + ex);
            }
            


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


            try
            {
                edpbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                namebox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                agebox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
              //  dobpicker.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                coursebox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                deptbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void searchbox_TextChanged(object sender, EventArgs e)
        //{
        //    DataView dv = dt.DefaultView;
        //    dv.RowFilter = "Name LIKE '%" + searchbox.Text + "%'";
        //    dataGridView1.DataSource = dv;
        //}
    }
}
