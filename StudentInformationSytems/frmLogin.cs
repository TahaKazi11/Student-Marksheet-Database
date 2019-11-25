using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb; //this is a class aka. Library 
//purpose is to access DB not microsoft access mind you
//Name: Taha Kazi
//Purpose: Basically a student info system, connected to an access database, where students log in and can check their marks. For the teachers (aka Admin) they can add students, edit info about students, edit students` marks, delete students.
//ENHANCEMENT: I used getset method for variables

namespace StudentInformationSytems
{
    public partial class frmLogin : Form
    {
        private OleDbConnection conn = new OleDbConnection(); //connectionstrings.com 

        public frmLogin()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students23.accdb;
Persist Security Info = False;";
            //DB connection parameter was adapted from connectionstrings.com
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lblStatus.Text = "Connected";
                conn.Close(); 
            }
            catch
            {
                MessageBox.Show("Database connection failed."); 
            }
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            //declaring oledDb just like File.Io
            OleDbCommand cmd = new OleDbCommand();
            //im going to link that command to connection object
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tblStudents WHERE UserName='" + txtUser.Text + "'AND Password='" + txtPass.Text + "'";

            //single quote to pass stuff between (ie. txtUser.Text and txtPass.text)

            //This is where the actual reding happens
            //creating an object reader and linking to command cmd to execute reading
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();
                string Pass1 = "";
                string Pass2 = "";
                int counter = 0;
                while (reader.Read())
                {
                    counter++; //counter will only increase by one if the username and password (aka pass 1 and pass2) are found in the database
                    Pass1 = reader["FirstName"].ToString();
                    Pass2 = reader["LastName"].ToString();
                }
                if (counter == 1)//this means the password is correct because the counter has been increased by 1
                {
                    MessageBox.Show("Welcome! " + Pass1 + ", " + Pass2);
                    this.Hide();
                    if (txtUser.Text == "admin") //if its the admin show the admin form
                    {
                        frmAdmin frm = new frmAdmin();
                        frm.ShowDialog();

                    }
                    else //if its the student show the student form
                    {
                        frmStudents frmStudents = new frmStudents(Pass1, Pass2); //note it passes the firstname and last name

                        frmStudents.ShowDialog();

                        //MessageBox.Show("Not there yet, will get updated soon! :)"); 
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username/Password.");
                }
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("" + Ex); //display the eror
            }

            
            

        }
    }
}
