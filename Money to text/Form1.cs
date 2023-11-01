using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_to_text
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

        private static string MoneyToText(int number)
        {
            string Words = "";

            if (number == 0) return "zero";

            if ((number / 1000000) > 0)
                Words += MoneyToText(number / 1000000) + " million ";
                number %= 1000000;

            if ((number / 1000) > 0)
                Words += MoneyToText(number / 1000) + " Thousand ";
                number %= 1000;

            if ((number / 100) > 0)
                Words += MoneyToText(number / 100) + " Hundred ";
                number %= 100;

            if (number > 0)
                if (Words != "") Words += " and ";
                var unitsMap = new[] { "zero", "one","two", "three", "four", "five", "six","seven","eight", "nine", "ten","eleven","twelve","thirteen", "fourteen", "fifteen","sixteen","seventeen","eighteen","nineteen" };
                var tensmap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty","sixty", "seventy", "eighty", "ninety"};
                
                if (number < 20)
                {
                    Words += unitsMap[number];
                }
                 else
                {
                    Words += tensmap[number / 10];
                if (number % 10 > 0)
                    Words += " " + unitsMap[number % 10];
                }




            return Words;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            TextConvert.Text = MoneyToText(int.Parse(MoneyIN.Text));
        }

        private void MoneyIN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
