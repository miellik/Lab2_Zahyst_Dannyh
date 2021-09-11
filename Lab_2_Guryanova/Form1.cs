using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_Guryanova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            labelDecimalP.Text = Convert.ToString(intP, 10);
            labelBinP.Text = Convert.ToString(intP, 2);
            textBox_P_reverse.Text = strP;

            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);
            labelDecimalKey.Text = Convert.ToString(intKey, 10);
            labelBinKey.Text = Convert.ToString(intKey, 2);
            textBox_Key_reverse.Text = strKey;

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            labelDecimalC.Text = Convert.ToString(intC, 10);
            labelBinC.Text = Convert.ToString(intC, 2);
            textBox_C.Text = strC;
            textBox_C_reverse.Text = strC;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";

        }
    }
}
