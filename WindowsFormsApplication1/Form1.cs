using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        double res;
        double num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = double.Parse(Visor.Text);
            res = num;
            for (int i = 0; i < (num  - 1) ; i++ )
            {
                res = res * (num - (i + 1));
              

            }
            lbl.Text = Convert.ToString(res);


        }
        public double rec(double hue) {
            if (hue == 0) 
            return  1;

            
            return hue * rec (hue - 1);
        }

        
         
        private void button3_Click(object sender, EventArgs e) 
        {

            num = double.Parse(Visor.Text);
            lbl.Text = Convert.ToString(rec(num));




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
