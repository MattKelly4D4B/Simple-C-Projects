using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimatorGUl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StrHours = textBox2.Text;
            double Hours = double.Parse(StrHours);

            string StrMiles = textBox1.Text;
            double Miles = double.Parse(StrMiles);

            double Price = 200 + (150 * Hours) + (2 * Miles);
            
            Result.Visible = true;
            Result.Text = "$" + Price;
        }
    }
}
