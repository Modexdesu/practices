using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice17form
{
    public partial class listform : Form
    {
        private StudentManager studentManager = new StudentManager();
        public listform()
        {
            InitializeComponent();
        }

        private void listform_Load(object sender, EventArgs e)
        {
            GetstudentList();
        }
        private void GetstudentList()
        {
            try
            {
                var students = studentManager.GetStudentlist();
                dataGridView1.Rows.Clear();
                foreach(var (name,age) in students)
                {
                    dataGridView1.Rows.Add(name, age);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching student list: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
