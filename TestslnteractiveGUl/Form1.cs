using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestslnteractiveGUl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StrTest1 = textBox1.Text;
            double Test1 = Int32.Parse(StrTest1);

            string StrTest2 = textBox2.Text;
            double Test2 = Int32.Parse(StrTest2);

            string StrTest3 = textBox3.Text;
            double Test3 = Int32.Parse(StrTest3);

            string StrTest4 = textBox4.Text;
            double Test4 = Int32.Parse(StrTest4);

            string StrTest5 = textBox5.Text;
            double Test5 = Int32.Parse(StrTest5);

            double Avg = (Test1 + Test2 + Test3 + Test4 + Test5) / 5;

            label8.Visible = true;
            label8.Text = Avg.ToString();


        }
    }
}
