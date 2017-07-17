using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar, indirim, toplam_tutar;
            tutar = Convert.ToInt32(textBox1.Text);
            indirim = Convert.ToDouble(textBox2.Text);
            toplam_tutar = tutar - (tutar * indirim) / 100;
            label3.Text = toplam_tutar.ToString();

         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
