using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        double obhesapla, not1;
        
        private void button1_Click(object sender, EventArgs e)
        {

            not1 = Convert.ToInt16(textBox4.Text);
            obhesapla = (not1*5)* 0.12;
            label1.Text = obhesapla.ToString();
  
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
