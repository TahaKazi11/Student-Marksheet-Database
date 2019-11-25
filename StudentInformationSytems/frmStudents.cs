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

namespace StudentInformationSytems
{
    public partial class frmStudents : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmStudents(string Pass1, string Pass2)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Students23.accdb;
Persist Security Info = False;";

            informationUpdate(Pass1,Pass2); 
        }



        private void frmStudents_Load(object sender, EventArgs e)
        {

        }
        public static string marks(int OverallAverage)
        {
            string Mark = ""; 
            //basically looking at the average and determining what level the student is at ex. if its more than 90 percent than the student is a 4+ stdent
            if (OverallAverage >= 90)
            {
                Mark = "4+";
            }
            else if (OverallAverage >= 85)
            {
                Mark = "4";
            }
            else if (OverallAverage >= 80)
            {
                Mark = "4-";
            }
            else if (OverallAverage > 75)
            {
                Mark = "3+";
            }
            else if (OverallAverage == 75)
            {
                Mark = "3";
            }
            else if (OverallAverage >= 70)
            {
                Mark = "3-";
            }
            else if (OverallAverage > 65)
            {
                Mark = "2+";
            }
            else if (OverallAverage == 65)
            {
                Mark = "2";
            }
            else if (OverallAverage >= 60)
            {
                Mark = "2-";
            }
            else if (OverallAverage > 55)
            {
                Mark = "1+";
            }
            else if (OverallAverage == 55)
            {
                Mark  = "1";
            }
            else if (OverallAverage >= 50)
            {
                Mark = "1-";
            }
            else
            {
                Mark = "Fail";
            }
            return Mark; 
        }

        private void btnChart_Click(object sender, EventArgs e) 
        {
            chartMarks.Series["Marks"].Enabled = true; //makes the chart visible for the user to see ('enables' it) 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); 
        }
        public void informationUpdate(string Pass1, string Pass2)
        {//here basically information is taken/read from the database and displayed to the user
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            //command.CommandText =  "SELECT tblStudents.StuID, FirstName, LastName, DOB, Mark1, Mark2, Mark3, Mark4, Mark5 FROM tblStudents LEFT JOIN tblMarks ON tblStudents.StuID = tblMarks.StuID WHERE LastName='" + Pass2 + "'AND FirstName='" + Pass1 + "'GROUP BY tblStudents.StuID, FirstName, LastName, DOB, Mark1, Mark2, Mark3, Mark4, Mark5";
            command.CommandText = "SELECT FirstName, LastName, DOB, Mark1, Mark2, Mark3, Mark4, Mark5, StuID FROM tblStudents WHERE LastName='" + Pass2 + "'AND FirstName='" + Pass1 + "'"; //SELECT basically asks access to return data as a set of records, it doesnt change anything in the database, here information of marks, DOB, FName, LName are returned of course WHERE the FirstName and LastName are equal to the first name and last name of the user logged in
            OleDbDataReader reader = command.ExecuteReader();//declaring the reader object

            reader.Read();
            txtFName.Text = reader["FirstName"].ToString();
            txtLName.Text = reader["LastName"].ToString();
            txtStuID.Text = reader["StuID"].ToString();
            txtDOB.Text = Convert.ToDateTime(reader["DOB"].ToString()).ToString("dd/MMM/yy");

            int Average = 0;
            int[] MarksRecord = new int[5];
            for (int i = 0; i < 5; i++)
            {
                //it reads from index based on how you read the database, in our case it starts at index 3
                lbMarks.Items.Add((reader[i + 3].ToString()) + Environment.NewLine);
                Average += int.Parse(reader[i + 3].ToString());
                MarksRecord[i] = int.Parse(reader[i + 3].ToString());

            }
            //the chart is formed here, all marks array contains all of the marks for the specific student/user
            int[] AllMarks = { MarksRecord[0], MarksRecord[1], MarksRecord[2], MarksRecord[3], MarksRecord[4] };
            //the labels are stored in a string array
            string[] Marks = { "Mark 1", "Mark 2", "Mark 3", "Mark 4", "Mark 5" };
            chartMarks.Series[0].Points.DataBindXY(Marks, AllMarks);//binds/combines the x and y together (with marks being the y and the labels being the x)
            chartMarks.Series["Marks"].Enabled = false;

            int OverallAverage = Average / 5;
            lblMarks.Text = marks(OverallAverage);

            txtAverage.Text = OverallAverage.ToString();
            reader.Close();
            connection.Close();
        }
    }
}
