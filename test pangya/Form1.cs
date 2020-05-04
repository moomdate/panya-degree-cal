using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_pangya
{
    public partial class kheehee : Form
    {
        int mouse_x;
        int mouse_y;
        public kheehee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           // this.mouse_x = e.X;
           //  this.mouse_y = e.Y;
           //  label1.Text = "X:" + e.X + " Y:"+  e.Y;

            label4.Text = this.getDeegree().ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private double getDeegree()
        {
            double result;
            if (this.mouse_y == 848)
            {
                return 90.0;
            }
            else
            {
                double a = Math.Abs(this.mouse_x - 1182);
                double b = Math.Abs(848 - this.mouse_y);
                label10.Text = a.ToString();
                label11.Text = b.ToString();

                double radians = Math.Atan(a /b);
                label7.Text = radians.ToString();
                result = (180.0 / Math.PI) * radians;
                return result;
            }
          
        }
        private void Test_Click(object sender, EventArgs e)
        {
            this.Size = new Size((int)w_w.Value,(int)w_h.Value);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Move(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.mouse_x = e.X;
            this.mouse_y = e.Y;
            label1.Text = "X:" + e.X + " Y:" + e.Y;

            label4.Text = this.getDeegree().ToString();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
