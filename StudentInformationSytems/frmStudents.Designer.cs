namespace StudentInformationSytems
{
    partial class frmStudents
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lbMarks = new System.Windows.Forms.ListBox();
            this.chartMarks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(86, 18);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.ReadOnly = true;
            this.txtStuID.Size = new System.Drawing.Size(100, 20);
            this.txtStuID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "D.O.B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Average";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(86, 56);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(86, 96);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(86, 125);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(100, 20);
            this.txtDOB.TabIndex = 8;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(86, 155);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 20);
            this.txtAverage.TabIndex = 9;
            // 
            // lbMarks
            // 
            this.lbMarks.FormattingEnabled = true;
            this.lbMarks.Location = new System.Drawing.Point(15, 184);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(186, 199);
            this.lbMarks.TabIndex = 10;
            // 
            // chartMarks
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMarks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMarks.Legends.Add(legend2);
            this.chartMarks.Location = new System.Drawing.Point(235, 184);
            this.chartMarks.Name = "chartMarks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Marks";
            this.chartMarks.Series.Add(series2);
            this.chartMarks.Size = new System.Drawing.Size(333, 201);
            this.chartMarks.TabIndex = 11;
            this.chartMarks.Text = "chartMarks";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(429, 115);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Level:";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(234, 158);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(41, 13);
            this.lblMarks.TabIndex = 15;
            this.lblMarks.Text = "lblMark";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 395);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chartMarks);
            this.Controls.Add(this.lbMarks);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.label1);
            this.Name = "frmStudents";
            this.Text = "Student Info";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.ListBox lbMarks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMarks;
    }
}