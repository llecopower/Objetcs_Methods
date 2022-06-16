using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetcs_Methods.Business;

namespace Objetcs_Methods
{
    public partial class Form1 : Form
    {
        private Course oGradeRecord = new Course();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            oGradeRecord.SetStudentId(12345);
            oGradeRecord.SetFirstName("Maria");
            oGradeRecord.SetLastName("Maria");
            oGradeRecord.SetMidtermGrade(100.0f);
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string display = oGradeRecord.GetInfo(oGradeRecord);
            MessageBox.Show(display, "Student record");
            labelInfo.Text = oGradeRecord.GetInfo(oGradeRecord); 


        }
    }
}
