using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
