using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradesLuminarias
{
    abstract class StudentNumericGrade
    {
        private int student_id;
        private string student_name;
        protected private double formative_grade;
        protected private double summative_grade;
        protected double initial_grade;

        public StudentNumericGrade(int student_id, string student_name, double formative_grade, double summative_grade, double total_grade)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.formative_grade = formative_grade;
            this.summative_grade = summative_grade;
            this.initial_grade = total_grade;
        }

       
        public double GetInitialGrade()
        {
            return initial_grade;
        }

        
        public abstract double GetFinalGrade();
        public abstract string GetLetterGrade();
    }

    class StudentLetterGrade : StudentNumericGrade
    {
        private int extra_credit;
        private double final_grade;
        private string letter_grade;

        public StudentLetterGrade(int student_id, string student_name, double formative_grade, double summative_grade, int extra_credit)
            : base(student_id, student_name, formative_grade, summative_grade, 0) 
        {
            this.extra_credit = extra_credit;
            this.final_grade = CalculateFinalGrade();
            this.letter_grade = CalculateLetterGrade();
        }

       
        private double CalculateFinalGrade()
        {
            initial_grade = (formative_grade * 0.3) + (summative_grade * 0.7);
            return initial_grade + extra_credit;
        }

        
        private string CalculateLetterGrade()
        {
            double mga = final_grade;

            if (mga >= 96.00 && mga <= 100.00)
                return "1.0";
            else if (mga > 92.75 && mga <= 95.99)
                return "1.25";
            else if (mga > 89.50  && mga <= 92.74)
                return "1.5";
            else if (mga > 86.25 && mga <= 89.49)
                return "1.75";
            else if (mga > 83.00 && mga <= 86.24)
                return "2.0";
            else if (mga > 79.75 && mga <= 82.99)
                return "2.25";
            else if (mga > 76.50 && mga <= 79.74)
                return "2.5";
            else if (mga > 73.25 && mga <= 76.49)
                return "2.75";
            else if (mga > 70.00 && mga <= 73.24)
                return "3.0";
            else if (mga == 69.99)
                return "5.0"; 
            else
                return "IP";   
        }

        
        public override double GetFinalGrade()
        {
            return final_grade;
        }

        public override string GetLetterGrade()
        {
            return letter_grade;
        }
    }
}








