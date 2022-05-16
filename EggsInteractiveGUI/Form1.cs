using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StrCh1 = textBox1.Text;
            int Ch1 = Int32.Parse(StrCh1);

            string StrCh2 = textBox2.Text;
            int Ch2 = Int32.Parse(StrCh2);

            string StrCh3 = textBox3.Text;
            int Ch3 = Int32.Parse(StrCh3);

            string StrCh4 = textBox4.Text;
            int Ch4 = Int32.Parse(StrCh4);

            string StrCh5 = textBox5.Text;
            int Ch5 = Int32.Parse(StrCh5);

            int EggSum = Ch1 + Ch2 + Ch3 + Ch4 + Ch5; //Compute total Eggs
            int Dozens = EggSum / 12;           // Compute Dozens of eggs.
            string StrDozens = Dozens.ToString();
            
            int Remainder = (EggSum % 12);      // Computer remainder.
            string StrRemainder = Remainder.ToString();
            
                label10.Visible = true;
            label10.Text = EggSum.ToString();

            label11.Visible = true;
            label11.Text = StrDozens;

            label12.Visible = true;
            label12.Text = StrRemainder;

        }
    }
}
