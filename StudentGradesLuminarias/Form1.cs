namespace StudentGradesLuminarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int studentID = int.Parse(txtStudentID.Text);
                string studentName = txtStudentName.Text;
                double formativeGrade = double.Parse(txtFormativeGrade.Text);
                double summativeGrade = double.Parse(txtSummativeGrade.Text);
                int extraCredit = int.Parse(txtExtraCredit.Text);

                
                StudentLetterGrade studentGrade = new StudentLetterGrade(studentID, studentName, formativeGrade, summativeGrade, extraCredit);

                
                lblInitialNumericGrade.Text = studentGrade.GetInitialGrade().ToString("F2");
                lblFinalNumericGrade.Text = studentGrade.GetFinalGrade().ToString("F2");
                lblLetterGrade.Text = studentGrade.GetLetterGrade();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter valid values for all fields.");
            }
        }

       
        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {        

        }
        private void txtStudentID_TextChanged(object sender, EventArgs e)
        { 

        }
        private void txtFormativeGrade_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSummativeGrade_TextChanged(object sender, EventArgs e)
        { 

        }
        private void txtExtraCredit_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblInitialNumericGrade_Click(object sender, EventArgs e)
        {

        }
        private void lblFinalNumericGrade_Click(object sender, EventArgs e)
        { 

        }
        private void lblLetterGrade_Click(object sender, EventArgs e)
        { 
        
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
