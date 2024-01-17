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
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer main = new System.Media.SoundPlayer();

        static int interval = 0;
        public Form1(int inter)
        {
            interval = inter;
            InitializeComponent();

            main.SoundLocation = "main.wav";
            main.Play();

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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            main.Stop();
            Form5 form5 = new Form5(interval);
            //this.Hide();
            form5.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            //this.Hide();
            form3.Show(this);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(interval);
           // this.Hide();
            form4.Show(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
