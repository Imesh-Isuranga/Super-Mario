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
    public partial class Form4 : Form
    {
        int interval;
        public Form4(int inter)
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

            interval = inter;
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(interval);
            this.Close();
            //this.Hide();
            //form1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
