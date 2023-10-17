using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbStudentTableAdapter.Fill(this.dbStudentsDataSet4.tbStudent);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           tbStudentBindingSource.EndEdit();
            tbStudentTableAdapter.Update(dbStudentsDataSet4.tbStudent);
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.RemoveCurrent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
           tbStudentBindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MoveFirst();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            tbStudentBindingSource.MovePrevious(); 
        }

        private void btnNxt_Click(object sender, EventArgs e)
        {
          tbStudentBindingSource.MoveNext();
        }
    }
}
