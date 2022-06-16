using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objetcs_Methods.Business
{
    public class Course
    { //custom methods
        private int studentId;

        public void SetStudentId(int sId)
            {
                studentId = sId;
            }

        public int GetStudentId()
            { 
                return studentId;
            }



        private string firstName;

        public void SetFirstName(string fname)
        {
            firstName = fname;
        }

        public string GetFirstName()
        {
            return firstName;
        }


        private string lastName;

        public void SetLastName(string lname)
        {
            lastName = lname;
        }

        public string GetLastName()
        {
            return lastName;
        }

        private float midtermGrade;
        public void SetMidtermGrade(float mTermGrade)
        {

            midtermGrade = mTermGrade;
        }

        public float GetMidtermGrade()
        { 
                   
            return midtermGrade;
        }

        public string GetInfo(Course oGradeRecord)
        {           


            string infoGrade = oGradeRecord.GetStudentId().ToString() + "\n" +
                               oGradeRecord.GetFirstName() + "\n" +
                               oGradeRecord.GetLastName() + "\n" +
                               oGradeRecord.GetMidtermGrade();
           
            return infoGrade;       
        
        }





    }
}
