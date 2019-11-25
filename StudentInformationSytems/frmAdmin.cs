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
    
    public partial class frmAdmin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int[] marks = new int[5];
        int globalID = -1;
        int LastID = -1; 
        public frmAdmin()
        {

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Students23.accdb;
Persist Security Info = False;";
            //the connection string borrowed from: https://www.connectionstrings.com/access/
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            PopulateCmbName();
            disableUpdate();
        }

        public void enableUpdate()
        {//enables a few textboxes and buttons for the user 
            txtBoxFName.Enabled = true;
            txtBoxLName.Enabled = true;
            txtBoxDOB.Enabled = true;
            btnSave.Visible = true;
            btnDelete.Visible = true;
           
        }

        public void disableUpdate()
        {//disables all the buttons and textboxes for the user
            txtBoxFName.Enabled = false;
            txtBoxLName.Enabled = false;
            txtBoxStuID.Enabled = false;
            txtBoxDOB.Enabled = false;
            btnSave.Visible = false;
            btnSaveNew.Visible = false;
            btnDelete.Visible = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)//user clicks edit mode and is prompted, and buttons are made visible
        {
            MessageBox.Show("You are about to enter edit mode, Make your changes and hit save.");

            enableUpdate();

        }

        private void PopulateCmbName()//to populate the combo box (aka drop-down menu)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                //storing the query into a string called query
                string query = "SELECT LastName, FirstName FROM tblStudents"; //the command is to select only the last name and the first name 
                //passing my query onto command text
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader(); 
                int Amount = 0; 
                while (reader.Read())//basically what happens here is: while there are first names and lastnames (aka until you reach the end of the database), it reads the names and then adds the names to the combo box
                {
                    cmbNames.Items.Add(reader[0].ToString() + "," + reader[1].ToString());
                    Amount++; //used for determining student ID
                }
                LastID = Amount+1; //will be explain further down..
                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                //for debug purposes
                MessageBox.Show(e.ToString());
                connection.Close();

            }

        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtMarks.Text = "";
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

               string query = "SELECT FirstName, LastName, DOB, Mark1, Mark2, Mark3, Mark4, Mark5, StuID FROM tblStudents WHERE LastName + ',' +FirstName='" + cmbNames.Text + "'";//basically this command retrieves the data for the specific name in the database, the name is written on the combo box
               
                command.CommandText = query; //the text for command is basically the query

                //the reader object is declared, reads whatever is selected
                OleDbDataReader reader = command.ExecuteReader();

                reader.Read(); //here is where it actually reads
                txtBoxFName.Text = reader["FirstName"].ToString(); //basically here we are just writing the data from the database into the textboxes
                txtBoxLName.Text = reader["LastName"].ToString();
                txtBoxStuID.Text = reader["StuID"].ToString();
                txtBoxDOB.Text = Convert.ToDateTime(reader["DOB"].ToString()).ToString("dd/MMM/yy");

                //this is to record and write the marks into the rich text box as well was used to calculate the average of the student
                int Average = 0;
                int[] MarksRecord = new int[5];//an array used to store the five marks
                for (int i = 0; i < 5; i++)//it will not check more than five marks
                {
                    //Also reader[i+3] is used because we are referring to mark 1, mark 2, mark 3 (looking at the query we can see FirstName as reader[0], LastName as reader[1] so to get/refer to Mark1 we use reader[3])
                    //it reads from index based on how you read the database, in our case it starts at index 3
                    txtMarks.Text += (reader[i + 3].ToString()) + Environment.NewLine;
                    Average += int.Parse(reader[i + 3].ToString()); //whatever number it says in the textbox is added to the average to later be divided by 5 to get the average
                    MarksRecord[i] = int.Parse(reader[i + 3].ToString()); //basically an array used as an record 

                }
                int Mark = Average / 5;
                lblMark.Text = Mark.ToString();


                //here we create the chart, All marks basically the data or number in this case which is the mark
                int[] AllMarks = { MarksRecord[0], MarksRecord[1], MarksRecord[2], MarksRecord[3], MarksRecord[4] }; 
                //string marks is what will be written along the x axis
                string[] Marks = { "Mark 1", "Mark 2", "Mark 3", "Mark 4", "Mark 5" };
                chartMarks.Series[0].Points.DataBindXY(Marks, AllMarks);//this is basically to draw the chart, it binds/combines these two data sets together to form a chart
                chartMarks.Series["Marks"].Enabled = false;//set to false because we dont want user to see until the user clicks chart


                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }
        private void enableNew()//basically enables everything required to edit
        {
            txtMarks.Enabled = true;
            txtBoxFName.Enabled = true;
            txtBoxLName.Enabled = true;
            txtBoxDOB.Enabled = true;

            cmbNames.Enabled = true;

            btnSaveNew.Visible = true;

        }

        private void clearText()
        {//clears text in the textboxes
            txtBoxFName.Text = "";
            txtBoxLName.Text = "";
            txtBoxDOB.Text = "";
            txtMarks.Text = "";
            cmbNames.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogresult = MessageBox.Show("Enter new data?", "Entering data", MessageBoxButtons.YesNo);//dialog box prompting the user to enter data or not
            if (dialogresult == DialogResult.Yes)//if the user clicks the yes button
            {
                enableNew();
                clearText();

            }
            else if (dialogresult == DialogResult.No)//if the user clicks the no button
            {
                btnSaveNew.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                
                int ID = int.Parse(txtBoxStuID.Text);
                globalID = ID; 
                string query = "DELETE FROM tblStudents WHERE StuID=" + ID;//basically the command to delete the row/record in the database...the WHERE StuID = ID part refers to where the ID is equal to the the one given to the program which is stored in txtBoxStuID.text

                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data deleted");
                connection.Close();
                //these methods are called to update the combo box.
                cmbNames.Items.Clear();
                PopulateCmbName();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string FName = txtBoxFName.Text;
            //this here is basically to check that the first name fields are clear of any invalid inputs (numbers). If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.
            int Fvalue = 5;
            for (int i = 0; i < FName.Length; i++)
            {
                char current = FName[i]; 
                if (FName[i] != '1' && FName[i] != '2' && FName[i] != '3' && FName[i] != '4' && FName[i] != '5' && FName[i] != '6' && FName[i] != '7' && FName[i] != '9' && FName[i] != '0')
                {
                    Fvalue = 5;
                }
                else
                {
                    Fvalue = 10;
                    break;
                }

            }
            string LName = txtBoxLName.Text;
            //same thing as first name just to check if there are valid input. If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.
            int Lvalue = 5;
            for (int i = 0; i < LName.Length; i++)
            {
                if (LName[i] != '1' && LName[i] != '2' && LName[i] != '3' && LName[i] != '4' && LName[i] != '5' && LName[i] != '6' && LName[i] != '7' && LName[i] != '9' && LName[i] != '0')
                {
                    Lvalue = 5;
                }
                else
                {
                    Lvalue = 10;
                    break;
                }

            }
            string DOB = txtBoxDOB.Text;
            int DOBvalue = 5;
            //here we are checking if the data inputted is correct in the exact format (02/Nov/99). If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.

            for (int i = 0;  i < DOB.Length; i++)
            {
                if (i == 0||i==1||i==2||i==6||i==7||i==8)
                {
                    if (DOB[i] != '1' && DOB[i] != '2' && DOB[i] != '3' && DOB[i] != '4' && DOB[i] != '5' && DOB[i] != '6' && DOB[i] != '7' && DOB[i] != '9' && DOB[i] != '0' && DOB[i] != '/')
                    {
                        DOBvalue = 10;
                        break;
                    }
                    else
                    {
                        DOBvalue = 5;
                    }
                }
                else if (i==3||i==4||i==5)
                {
                    if (DOB[i] != '1' && DOB[i] != '2' && DOB[i] != '3' && DOB[i] != '4' && DOB[i] != '5' && DOB[i] != '6' && DOB[i] != '7' && DOB[i] != '9' && DOB[i] != '0' && DOB[i] != '/')
                    {
                        DOBvalue = 5;
                    }
                    else
                    {
                        DOBvalue = 10;
                        break;
                    }
                }
            }
            try
            {
                //if there are no problems with the input the value should be 5 for the first name, last name and DOB values
                if (Fvalue == 5 && Lvalue == 5 && DOBvalue == 5)
                {
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    connection.Open();
                    int ID = int.Parse(txtBoxStuID.Text);
                    
                    //Enhancement used here
                    Input ns = new Input();
                    ns.FirstNames = txtBoxFName.Text;
                    ns.LastNames = txtBoxLName.Text;
                    ns.DOBs = txtBoxDOB.Text; 
           
                    string query = "UPDATE tblStudents SET FirstName='" + ns.FirstNames + "', LastName='" + ns.LastNames + "', DOB='" + ns.DOBs + "'WHERE StuId=" + ID; //basically updates the information in the database (since it was edited, or is assumed to be) where the student ID is equal to the ID given to the program for the specific student
                    var accessUpdateCommand = new OleDbCommand(query, connection);
                    //accessUpdateCommand.Parameters.AddWithValue("FirstName", txtBoxFName.Text);
                    accessUpdateCommand.Parameters.AddWithValue("id", "StuID"); // Replace "123" with the variable where your ID is stored. Maybe row[0] ?
                    da.UpdateCommand = accessUpdateCommand;
                    da.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show(query); 
                    

                    string query1 = "";
                    string Marks = txtMarks.Text;
                    //splits at every single new line
                    string[] Marks2 = Marks.Split('\n');
                    int[] Marks3 = new int[5];
                    int value = 0; 

                    //these loops are here to store the marks in the textbox to an array, and if they are parseable into integers then value is going to be 5, which is then used to determine if the marks inputted is valid or not
                  for (int i = 0; i < 5; i++)
                    {
                        // Marks3[i] = int.Parse(Marks2[i]);
                        if (int.TryParse(Marks2[i], out Marks3[i]))
                        {
                            value = 5;
                        }
                        else
                        {

                            value = 10;
                            break;
                        }
                    }
                    if (value == 5)//if it is valid then it will continue executing the rest of the code
                    {
                        for (int i = 0; i < 5; i++)//here it basically executes each and every time for different marks, basically these commands are to update the database for Mark1, Mark2, Mark3 and so on, basically updating the database with the new marks the user inputted
                        {
                            if (i == 0)
                            {
                                query1 = "UPDATE tblStudents SET Mark1='" + Marks3[i] + "' WHERE StuId=" + ID;

                            }
                            else if (i == 1)
                            {
                                query1 = "UPDATE tblStudents SET Mark2='" + Marks3[i] + "' WHERE StuId=" + ID;
                            }
                            else if (i == 2)
                            {
                                query1 = "UPDATE tblStudents SET Mark3='" + Marks3[i] + "' WHERE StuId=" + ID;
                            }
                            else if (i == 3)
                            {
                                query1 = "UPDATE tblStudents SET Mark4='" + Marks3[i] + "' WHERE StuId=" + ID;
                            }
                            else if (i == 4)
                            {
                                query1 = "UPDATE tblStudents SET Mark5='" + Marks3[i] + "' WHERE StuId=" + ID;
                            }
                           
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = connection;
                            cmd.CommandText = query1;
                            cmd.ExecuteNonQuery();

                        }

                        MessageBox.Show("Data Saved");

                        connection.Close();
                        cmbNames.Items.Clear();
                        PopulateCmbName();

                    }
                    else//if the value is 10, meaning the data isnt valid, user is informed about that
                    {
                        MessageBox.Show("Please enter a valid mark.");
                    }
                } 
                else //if the value isnt 5 (its 10) then user is prompted that theres something wrong with the input
                {
                    MessageBox.Show("One (or more) of the fields do not have the right data. Please re-type the data. (ex. DOB should be typed 02/Feb/93)");
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error" + ex);

            }

        }


        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            //this here is basically to check that the first name fields are clear of any invalid inputs (numbers). If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.
            string FName = txtBoxFName.Text;
            int Fvalue = 5;
            for (int i = 0; i < FName.Length; i++)
            {
                char current = FName[i];
                if (FName[i] != '1' && FName[i] != '2' && FName[i] != '3' && FName[i] != '4' && FName[i] != '5' && FName[i] != '6' && FName[i] != '7' && FName[i] != '9' && FName[i] != '0')
                {
                    Fvalue = 5;
                }
                else
                {
                    Fvalue = 10;
                    break;
                }

            }
            string LName = txtBoxLName.Text;
            int Lvalue = 5;
            //same thing as first name just to check if there are valid input. If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.
            for (int i = 0; i < LName.Length; i++)
            {
                if (LName[i] != '1' && LName[i] != '2' && LName[i] != '3' && LName[i] != '4' && LName[i] != '5' && LName[i] != '6' && LName[i] != '7' && LName[i] != '9' && LName[i] != '0')
                {
                    Lvalue = 5;
                }
                else
                {
                    Lvalue = 10;
                    break;
                }

            }
            string DOB = txtBoxDOB.Text;
            int DOBvalue = 5;

            //here we are checking if the data inputted is correct in the exact format (02/Nov/99). If data isnt correct it will break out of the loop, the loop basically checks all of the keys inputted.
            for (int i = 0; i < DOB.Length; i++)
            {
                if (i == 0 || i == 1 || i == 2 || i == 6 || i == 7 || i == 8)
                {
                    if (DOB[i] != '1' && DOB[i] != '2' && DOB[i] != '3' && DOB[i] != '4' && DOB[i] != '5' && DOB[i] != '6' && DOB[i] != '7' && DOB[i] != '9' && DOB[i] != '0' && DOB[i] != '/')
                    {
                        DOBvalue = 10;
                        break;
                    }
                    else
                    {
                        DOBvalue = 5;
                    }
                }
                else if (i == 3 || i == 4 || i == 5)
                {
                    if (DOB[i] != '1' && DOB[i] != '2' && DOB[i] != '3' && DOB[i] != '4' && DOB[i] != '5' && DOB[i] != '6' && DOB[i] != '7' && DOB[i] != '9' && DOB[i] != '0' && DOB[i] != '/')
                    {
                        DOBvalue = 5;
                    }
                    else
                    {
                        DOBvalue = 10;
                        break;
                    }
                }
            }
            //if there are no problems with the input the value should be 5 for the first name, last name and DOB values
            
            try
            {
                if (Fvalue == 5 && Lvalue == 5 && DOBvalue == 5)
                {


                    OleDbDataAdapter da = new OleDbDataAdapter();
                    connection.Open();
                    string Marks = txtMarks.Text;
                    string[] Marks2 = Marks.Split('\n');
                    int[] Marks3 = new int[5];

                    int value = 5;
                    for (int i = 0; i < 5; i++)
                    {
                        
                        if (int.TryParse(Marks2[i],out Marks3[i]))
                        {
                            value = 5; 
                        }
                        else
                        {
                            
                            value = 10;
                            break; 
                        }
                    }
                    if (value == 5)
                    {
                        //Enhancement, using the get set method!!
                        Input nw = new Input(); 
                        nw.FirstNames = txtBoxFName.Text;
                        nw.LastNames = txtBoxLName.Text;
                        nw.DOBs = txtBoxDOB.Text;

                        MessageBox.Show(nw.FirstNames + "," + nw.LastNames); 

                        
                        string query1 = "";
                            //global ID is basically used to check if data has been deleted, its default value is -1
                        if (globalID == -1)//so basically the query is the following if the data hasnt been deleted 
                        {
                            query1 = "INSERT INTO tblStudents (FirstName, LastName,DOB,Mark1,Mark2,Mark3,Mark4,Mark5,StuID) VALUES ('" + nw.FirstNames + "','" + nw.LastNames + "','" + nw.DOBs + "'," + Marks3[0] + "," + Marks3[1] + "," + Marks3[2] + "," + Marks3[3] + "," + Marks3[4] + "," + LastID + ")"; //command to insert new data into the database, basically inserts into tblStudents the firstname, lastname, DOB and Mark1, Mark2, Mark3 and so on, to summarize user is just entering a new record
                        }
                        else//the query is the following if data has been deleted 
                        {
                            query1 = "INSERT INTO tblStudents (FirstName, LastName,DOB,Mark1,Mark2,Mark3,Mark4,Mark5,StuID) VALUES ('" + txtBoxFName.Text + "','" + nw.LastNames + "','" + nw.DOBs + "'," + Marks3[0] + "," + Marks3[1] + "," + Marks3[2] + "," + Marks3[3] + "," + Marks3[4] + "," + globalID + ")";//
                            globalID = -1;
                        }
                        var accessUpdateCommand = new OleDbCommand(query1, connection);
                        MessageBox.Show(query1);
                        OleDbCommand cmd1 = new OleDbCommand();
                        cmd1.CommandText = query1;
                        cmd1.Connection = connection;
                        cmd1.ExecuteNonQuery();//executes the command

                        connection.Close();
                        cmbNames.Items.Clear();
                        PopulateCmbName();
                    }
                    else
                    {
                        MessageBox.Show("Please insert a valid mark.");
                    }
                }
                else
                {
                    MessageBox.Show("One (or more) of the fields do not have the right data. Please re-type the data. (ex. DOB should be typed 02/Feb/93)");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();
            }

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //basically the command to exit out of the program
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            chartMarks.Series["Marks"].Enabled = true; //shows the chart (default is false/hidden)
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            chartMarks.Series["Marks"].Enabled = false; //hides the chart
        }
    }
}
