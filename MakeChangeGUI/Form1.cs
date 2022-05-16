using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeChangeGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StrMoney = textBox1.Text;
            double Money = double.Parse(StrMoney);

            double Hundred = 100;
            double Fifty = 50;
            double Twenty = 20;
            double Ten = 10;
            double Five = 5;
            double One = 1;
            double Quarter = .25;
            double Dime = .10;
            double Nickel = .05;
            double Penny = .01;

            double NumHundred = (int)(Money / Hundred);
            double NumFifty = (int)((Money % Hundred) / Fifty);
            double NumTwenty = (int)(((Money % Hundred) % Fifty) / Twenty);
            double NumTen = (int)((((Money % Hundred) % Fifty) % Twenty) / Ten);
            double NumFive = (int)(((((Money % Hundred) % Fifty) % Twenty) % Ten) / Five);
            double NumOne = (int)((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) / One);
            double NumQuarter = (int)(((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) / Quarter);
            double NumDime = (int)((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) / Dime);
            double NumNickel = (int)(((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) % Dime) / Nickel);
            double NumPenny = (int)((((((((((Money % Hundred) % Fifty) % Twenty) % Ten) % Five) % One) % Quarter) % Dime) % Nickel) / Penny);

            label12.Visible = true;
            label12.Text = NumHundred.ToString();

            label15.Visible = true;
            label15.Text = NumFifty.ToString();

            label13.Visible = true;
            label13.Text = NumTwenty.ToString();

            label16.Visible = true;
            label16.Text = NumTen.ToString();

            label18.Visible = true;
            label18.Text = NumFive.ToString();

            label20.Visible = true;
            label20.Text = NumOne.ToString();

            label14.Visible = true;
            label14.Text = NumQuarter.ToString();

            label17.Visible = true;
            label17.Text = NumDime.ToString();

            label19.Visible = true;
            label19.Text = NumNickel.ToString();

            label21.Visible = true;
            label21.Text = NumPenny.ToString();

        }
    }
}
