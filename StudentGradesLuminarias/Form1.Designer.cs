namespace StudentGradesLuminarias
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSGC = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtFormativeGrade = new TextBox();
            txtSummativeGrade = new TextBox();
            txtExtraCredit = new TextBox();
            btnCalculate = new Button();
            lblInitialNumericGrade = new Label();
            lblFinalNumericGrade = new Label();
            lblLetterGrade = new Label();
            lblFormative = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // lblSGC
            // 
            lblSGC.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSGC.ForeColor = SystemColors.ControlText;
            lblSGC.Location = new Point(193, 40);
            lblSGC.Name = "lblSGC";
            lblSGC.Size = new Size(354, 43);
            lblSGC.TabIndex = 0;
            lblSGC.Text = "Student Grade Calculator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 133);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 19;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 270);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 4;
            label4.Text = "Summative Grade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 233);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 5;
            label5.Text = "Extra Credit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 397);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 6;
            label6.Text = "Initial Numeric Grade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 436);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 7;
            label7.Text = "Final Numeric Grade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 481);
            label8.Name = "label8";
            label8.Size = new Size(167, 20);
            label8.TabIndex = 8;
            label8.Text = "Equivalent Letter Grade:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(130, 132);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(161, 27);
            txtStudentID.TabIndex = 9;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(449, 136);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(222, 27);
            txtStudentName.TabIndex = 10;
            // 
            // txtFormativeGrade
            // 
            txtFormativeGrade.Location = new Point(194, 240);
            txtFormativeGrade.Name = "txtFormativeGrade";
            txtFormativeGrade.Size = new Size(125, 27);
            txtFormativeGrade.TabIndex = 11;
            // 
            // txtSummativeGrade
            // 
            txtSummativeGrade.Location = new Point(194, 273);
            txtSummativeGrade.Name = "txtSummativeGrade";
            txtSummativeGrade.Size = new Size(125, 27);
            txtSummativeGrade.TabIndex = 12;
            // 
            // txtExtraCredit
            // 
            txtExtraCredit.Location = new Point(514, 233);
            txtExtraCredit.Name = "txtExtraCredit";
            txtExtraCredit.Size = new Size(125, 27);
            txtExtraCredit.TabIndex = 13;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(320, 331);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 14;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // lblInitialNumericGrade
            // 
            lblInitialNumericGrade.Location = new Point(289, 397);
            lblInitialNumericGrade.Name = "lblInitialNumericGrade";
            lblInitialNumericGrade.Size = new Size(314, 25);
            lblInitialNumericGrade.TabIndex = 15;
            // 
            // lblFinalNumericGrade
            // 
            lblFinalNumericGrade.Location = new Point(289, 436);
            lblFinalNumericGrade.Name = "lblFinalNumericGrade";
            lblFinalNumericGrade.Size = new Size(314, 25);
            lblFinalNumericGrade.TabIndex = 16;
            // 
            // lblLetterGrade
            // 
            lblLetterGrade.Location = new Point(290, 480);
            lblLetterGrade.Name = "lblLetterGrade";
            lblLetterGrade.Size = new Size(313, 25);
            lblLetterGrade.TabIndex = 17;
            // 
            // lblFormative
            // 
            lblFormative.AutoSize = true;
            lblFormative.Location = new Point(65, 238);
            lblFormative.Name = "lblFormative";
            lblFormative.Size = new Size(122, 20);
            lblFormative.TabIndex = 20;
            lblFormative.Text = "Formative Grade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(336, 139);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 21;
            label9.Text = "Student Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 543);
            Controls.Add(label9);
            Controls.Add(lblFormative);
            Controls.Add(lblLetterGrade);
            Controls.Add(lblFinalNumericGrade);
            Controls.Add(lblInitialNumericGrade);
            Controls.Add(btnCalculate);
            Controls.Add(txtExtraCredit);
            Controls.Add(txtSummativeGrade);
            Controls.Add(txtFormativeGrade);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblSGC);
            Name = "Form1";
            Text = "Student Grade Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSGC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtFormativeGrade;
        private TextBox txtSummativeGrade;
        private TextBox txtExtraCredit;
        private Button btnCalculate;
        private Label lblInitialNumericGrade;
        private Label lblFinalNumericGrade;
        private Label lblLetterGrade;
        private Label lblFormative;
        private Label label9;
    }
}

