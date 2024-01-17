using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Mario
{
    public partial class Form3 : Form
    {
        static int a = 2;

        int interval;


        public Form3()
        {

            //this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1280;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 800f;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }

            InitializeComponent();
            if (a == 1)
            {
                easy.BackColor = Color.Red;
                interval = 90;
            }

            if (a == 2)
            {
                normal.BackColor = Color.Red;
                interval = 80;
            }

            if (a == 3)
            {
                hard.BackColor = Color.Red;
                interval = 60;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            a = 1;
            interval = 90;
            Form1 form1 = new Form1(90);
            easy.BackColor = Color.Red;
            normal.BackColor = Color.Gainsboro;
            hard.BackColor = Color.Gainsboro;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            a = 2;
            interval = 70;
            Form1 form1 = new Form1(70);
            easy.BackColor = Color.Gainsboro;
            normal.BackColor = Color.Red;
            hard.BackColor = Color.Gainsboro;
        }

        private void hard_Click(object sender, EventArgs e)
        {
            a = 3;
            interval = 60;
            Form1 form1 = new Form1(60);
            easy.BackColor = Color.Gainsboro;
            normal.BackColor = Color.Gainsboro;
            hard.BackColor = Color.Red;
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(interval);
            //this.Hide();
            this.Close();
            //form1.Show();
        }
    }
}
