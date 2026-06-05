using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace practice17form
{
    public partial class Form1 : Form
    {
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e) //see list
        {
            listform listForm = new listform();
            listForm.Show();
        }

        private void button1_Click(object sender, EventArgs e) //delete
        {
            StudentManager studentManager = new StudentManager();
            studentManager.DeleteStudent(textBox1.Text, int.Parse(textBox2.Text));
            Console.WriteLine("student deleted");
        }

        private void addbutton_Click(object sender, EventArgs e) //add
        {
            StudentManager studentManager = new StudentManager();
            studentManager.AddStudent(textBox1.Text, int.Parse(textBox2.Text));
        }

        private void button2_Click_1(object sender, EventArgs e) //update
        {
            this.Close();
            string inputtedname = textBox1.Text;
            int inputtedage = int.Parse(textBox2.Text);
            updateform updateForm = new updateform();
            updateForm.inputtedname = inputtedname;
            updateForm.inputtedage = inputtedage;
            updateForm.Show();

        }
    }
    }


