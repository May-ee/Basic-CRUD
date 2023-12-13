using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.KeyPreview = true;
            getstudents();
            
        }

        private void getstudents()  //method to display the data in db in gridview
        {

            try
            {
                btnupdatestud.Enabled = false; //disabling update button on load
                btndeletestud.Enabled = false; //disabling delete button on load
                conn.Open();   //connection open
                string query = "SELECT * FROM students";  //string carrying query of select
                OleDbCommand cmd = new OleDbCommand(query, conn);  //commmand referring to query in connection with db
                cmd.ExecuteNonQuery(); //executing query command
                DataTable dt = new DataTable(); //declaring data table
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);  // declaring adapter for the data set, gotte from the command query
                adapter.Fill(dt); //the data set in the adapter will fill the dt or the data table declared above
                dataGridView1.DataSource = dt;  //dataGridView1 will npw have the datatable in dt as data source of display
                conn.Close(); // connection close
            }
            catch (Exception ex)
            {
                conn.Close(); //if error occurs connection close
                MessageBox.Show(ex.Message); // displays error in a message box
                return;
            }

        }



        private void ClearForm() //Method to Clear the textbox inputs
        {
            edpbox.ReadOnly = false;
            edpbox.Text = "";
            namebox.Text = "";
            agebox.Text = "";
            coursebox.Text = "";
            deptbox.Text = "";
        }


        private void btnaddsavestud_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open(); // opens connection with db

                string query = "INSERT INTO students (EDP, Name, Age, Course, Department) VALUES (@Edp, Name, Age, Course , Dept)";  //variable string carrying the quesry
                cmd = new OleDbCommand(query, conn); //new command in db, navigated by the string query to the connection db

                //To ensure that input is in digit and only has 6 digit characters
                if(edpbox.Text != "" && edpbox.Text.Length == 6)
                {
                    cmd.Parameters.AddWithValue("@Edp", int.Parse(edpbox.Text)); //if conditions met, input will be a parameter in queary
                }
                else
                {
                    MessageBox.Show("Inter only 6 integers for EDP number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice of error
                    conn.Close(); //close connection if catched with error
                    edpbox.Focus(); //will focus to textbix object
                    return; //return to input

                }

                
                cmd.Parameters.AddWithValue("Name", namebox.Text); //parameter for query


                if (agebox.Text != "" && agebox.Text.Length <= 3) //checks is the textbox is not empty and if the inputted digit is not less than length of 3
                {
                    cmd.Parameters.AddWithValue("Age", agebox.Text); //if conditions met, input will be a parameter in query
                }
                else
                {
                    MessageBox.Show("Input a valid Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();  //closes connection when catches error
                    agebox.Focus(); //will focus on tetbox age in return
                    return; //return to input
                }

               

                cmd.Parameters.AddWithValue("Course", coursebox.Text);  //parameter for query
                cmd.Parameters.AddWithValue("Dept", deptbox.Text);    //parameter for query

                cmd.ExecuteNonQuery();  //to execute the query //nonquery since we do not need a visual result to the table but we modify it using INSERT
        
                MessageBox.Show("Student Record Added", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice of success action

                conn.Close(); //closes connection when donw
                ClearForm();  //method to clear textboxes
                getstudents();  //method to update the gridview

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the Form", "input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice of success action //when error show message in a message box
                conn.Close(); //closes connection in db
                return; //returns to input
            }
           
        }

        private void btnupdatestud_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();  // opens connection with db

                

                string query = "UPDATE students SET Name = @Name, Age = @Age, Course = @Course, Department = @Dept WHERE EDP = @Edp";  //variable string carrying the quesry
                cmd = new OleDbCommand(query, conn); //new command in db, navigated by the string query to the connection db

                cmd.Parameters.AddWithValue("@Name", namebox.Text); //parameter fir update query

                if (agebox.Text != "" && agebox.Text.Length <= 3)  //checks is the textbox is not empty and if the inputted digit is not less than length of 3
                {
                    cmd.Parameters.AddWithValue("@Age", agebox.Text); //if conditions met, input will be a parameter in query to insert
                }
                else
                {
                    MessageBox.Show("input a valid Age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();  //closes connection when catches error
                    agebox.Focus(); //will focus on tetbox age in return
                    return; //return to input
                }

                cmd.Parameters.AddWithValue("@Course", coursebox.Text);  //parameter fir update query
                cmd.Parameters.AddWithValue("@Dept", deptbox.Text);  //parameter fir update query
                cmd.Parameters.AddWithValue("@Edp", int.Parse(edpbox.Text));   //parameter fir update query

                cmd.ExecuteNonQuery(); //to execute the query //nonquery since we do not need a visual result to the table but we modify it using INSERT


                MessageBox.Show("Student Record Updated", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();  //closes connection with db
                ClearForm();  //method to clear textboxes
                getstudents();  //method to update the gridview

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update the Form", "input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice of success action //when error show message in a message box
                conn.Close(); //closes connection in db
                return; //returns to input
            }
           
            

        }

        private void btndeletestud_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //connection open

                string query = "DELETE * FROM students WHERE EDP = @Edp"; //string carrying the query
                cmd = new OleDbCommand(query, conn);  //new command in db, navigated by the string query to the connection db
                cmd.Parameters.AddWithValue("@Edp", int.Parse(edpbox.Text));  //parameter for the query
                cmd.ExecuteNonQuery(); //to execute the query //nonquery since we do not need a visual result to the table but we modify it using INSERT
                conn.Close(); //connection close with db
                MessageBox.Show("Student Record Deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice
                getstudents(); //method to loadup display in datagridview
                ClearForm(); //method to clear textbox input
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select a Data First", "input Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information); //notice of success action //when error show message in a message box
                conn.Close(); //closes connection in db
                return; //returns to input
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                edpbox.ReadOnly = true;  //to disable input
                btnupdatestud.Enabled = true;  //enabling update in pressed on data in datagridview
                btndeletestud.Enabled = true;  //enabling delete in pressed on data in datagridview
                edpbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();  //getting values in datagridview to the textbox
                namebox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                agebox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                coursebox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                deptbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //notice to error
            }
        }

        private void LandForm_KeyDown(object sender, KeyEventArgs e)
        {   //event handling in keydown
            if (e.KeyCode == Keys.Escape) 
            { 
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnaddsavestud_Click(sender, e);
            }
        }

        private void edpbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Event handling in keypress in edp box to ensure that only digits can be inputted
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void agebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Event handling in keypress in age box to ensure that only digits can be inputted
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }



    }
}
