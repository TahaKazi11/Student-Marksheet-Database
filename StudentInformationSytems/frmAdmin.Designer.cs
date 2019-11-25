namespace StudentInformationSytems
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxStuID = new System.Windows.Forms.TextBox();
            this.txtBoxDOB = new System.Windows.Forms.TextBox();
            this.txtBoxLName = new System.Windows.Forms.TextBox();
            this.txtBoxFName = new System.Windows.Forms.TextBox();
            this.chartMarks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtMarks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "D.O.B";
            // 
            // txtBoxStuID
            // 
            this.txtBoxStuID.Location = new System.Drawing.Point(92, 18);
            this.txtBoxStuID.Name = "txtBoxStuID";
            this.txtBoxStuID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStuID.TabIndex = 4;
            // 
            // txtBoxDOB
            // 
            this.txtBoxDOB.Location = new System.Drawing.Point(92, 95);
            this.txtBoxDOB.Name = "txtBoxDOB";
            this.txtBoxDOB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDOB.TabIndex = 5;
            // 
            // txtBoxLName
            // 
            this.txtBoxLName.Location = new System.Drawing.Point(92, 70);
            this.txtBoxLName.Name = "txtBoxLName";
            this.txtBoxLName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLName.TabIndex = 6;
            // 
            // txtBoxFName
            // 
            this.txtBoxFName.Location = new System.Drawing.Point(93, 44);
            this.txtBoxFName.Name = "txtBoxFName";
            this.txtBoxFName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFName.TabIndex = 7;
            // 
            // chartMarks
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMarks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMarks.Legends.Add(legend1);
            this.chartMarks.Location = new System.Drawing.Point(198, 139);
            this.chartMarks.Name = "chartMarks";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Marks";
            this.chartMarks.Series.Add(series1);
            this.chartMarks.Size = new System.Drawing.Size(286, 303);
            this.chartMarks.TabIndex = 9;
            this.chartMarks.Text = "chart1";
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(286, 44);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(121, 21);
            this.cmbNames.TabIndex = 10;
            this.cmbNames.SelectedIndexChanged += new System.EventHandler(this.cmbNames_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(445, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(607, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(526, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(490, 168);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(75, 23);
            this.btnClearChart.TabIndex = 14;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(490, 139);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 15;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Location = new System.Drawing.Point(526, 76);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNew.TabIndex = 16;
            this.btnSaveNew.Text = "Save";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(445, 76);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(11, 141);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(181, 301);
            this.txtMarks.TabIndex = 18;
            this.txtMarks.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Overall Average:";
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(304, 105);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(35, 13);
            this.lblMark.TabIndex = 20;
            this.lblMark.Text = "label6";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(607, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 468);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.chartMarks);
            this.Controls.Add(this.txtBoxFName);
            this.Controls.Add(this.txtBoxLName);
            this.Controls.Add(this.txtBoxDOB);
            this.Controls.Add(this.txtBoxStuID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxStuID;
        private System.Windows.Forms.TextBox txtBoxDOB;
        private System.Windows.Forms.TextBox txtBoxLName;
        private System.Windows.Forms.TextBox txtBoxFName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarks;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RichTextBox txtMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnExit;
    }
}