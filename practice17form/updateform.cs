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
    public partial class updateform : Form
    {
       public string inputtedname,name;
        public int inputtedage,age;
        public updateform()
        {

            InitializeComponent();
            
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateform_Load(object sender, EventArgs e)
        {
            label1.Text = $"previous name: {inputtedname}";
            label2.Text = $"previous age: {inputtedage}";
        }
    }
}
