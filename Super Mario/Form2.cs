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
    public partial class Form2 : Form
    {
        int gravityUp = 20;
        int gravityDown = 20;
        int manMove = 20;
        int boxSpeed = 10;
        int lifeCount = 3;
        int gameScore = 0;
        int manFreeTime = 3000;
        int interval = 80;
        int target = 1000;
        int whetherStartOrNot = 1;
        int clickOrNot = 0;
        string name;
        int freeVar = 0;
        int pauseGame = 1;

        System.Media.SoundPlayer play = new System.Media.SoundPlayer();
        System.Media.SoundPlayer point = new System.Media.SoundPlayer();
        System.Media.SoundPlayer blast = new System.Media.SoundPlayer();
        System.Media.SoundPlayer wing = new System.Media.SoundPlayer();
        


        public Form2(int inter)
        {
            interval = inter;
            InitializeComponent();
            screenResolution();

            modeSpeed();

            play.SoundLocation = "play.wav";
            point.SoundLocation = "point.wav";
            blast.SoundLocation = "blast.wav";
            wing.SoundLocation = "wing.wav";
        }

        public Form2(int inter,string name)
        {
            play.SoundLocation = "play.wav";
            point.SoundLocation = "point.wav";
            blast.SoundLocation = "blast.wav";
            wing.SoundLocation = "wing.wav";


            interval = inter;
            this.name = name;
            InitializeComponent();
            screenResolution();

            modeSpeed();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(man.Top < -50)
            {
                gravityUp = 0;
            }else
            {
                gravityUp = 15;
            }

            if (man.Top > 340 ) 
            {
                gravityDown = 0;
            }else
            {
                gravityDown = 15;
            }

            if(man.Left > 850)
            {
                man.Left = 0;
            }

            if(whetherStartOrNot == 1)
            {
                targetSelector();
            }

            if (clickOrNot == 1)
            {
                startLbl.Visible = false;
                ready.Visible = false;
                timer.Interval = interval;
                manFreeTime += interval;
                man.Left += boxSpeed / 3;
                box1.Left -= boxSpeed;
                box2.Left -= boxSpeed*2;
                box4.Left -= (boxSpeed+5);
                bomb1.Left -= (boxSpeed*3);
                bomb2.Left -= boxSpeed;
                life.Left -= boxSpeed;
                manFaddingEffect();

                if(gameScore >= target)
                {
                    endGame();
                }

                if ((man.Bounds.IntersectsWith(box1.Bounds) || man.Bounds.IntersectsWith(box2.Bounds) || man.Bounds.IntersectsWith(box4.Bounds) || man.Bounds.IntersectsWith(bomb1.Bounds) || man.Bounds.IntersectsWith(bomb2.Bounds)) && manFreeTime > 3000)
                {
                    if (man.Bounds.IntersectsWith(bomb1.Bounds) || man.Bounds.IntersectsWith(bomb2.Bounds))
                    {
                        blast.Play();
                    }
                    else 
                    {
                        wing.Play();
                    }
                   
                            if (lifeCount == 3 && manFreeTime > 3000)
                            {
                                lifeCount--;
                                h3.Visible = false;
                                manFreeTime = 0;
                    }
                            if (lifeCount == 2 && manFreeTime > 3000)
                            {
                                lifeCount--;
                                h2.Visible = false;
                                manFreeTime = 0;
                    }

                            if (lifeCount == 1 && manFreeTime > 3000)
                            {
                                lifeCount--;
                                h1.Visible = false;
                                manFreeTime = 0;
                    }

                            if (lifeCount == 0 && manFreeTime > 3000)
                            {
                                endGame();
                            }

                }

                if((man.Bounds.IntersectsWith(bomb1.Bounds) || man.Bounds.IntersectsWith(bomb2.Bounds))  && manFreeTime < 3000)
                {
                    if(manFreeTime < 20)
                    {
                        this.BackColor = Color.Red;
                    }else
                    {
                        this.BackColor = Color.PaleGreen;
                    }

                }



                if (box1.Left < -10)
                {
                    gameScore += 10;
                    box1.Left = 850;
                }

                if (box2.Left < -10)
                {
                    gameScore += 10;
                    box2.Left = 900;
                }

                if (box4.Left < -10)
                {
                    gameScore += 10;
                    box4.Left = 950;
                }

                if (life.Left < -10)
                {
                    life.Left = 2000;
                }

                if (bomb1.Left < -10)
                {
                    bomb1.Left = 4000;
                }

                if (bomb2.Left < -10)
                {
                    bomb2.Left = 3500;
                }

                

                if ((man.Bounds.IntersectsWith(life.Bounds))  && manFreeTime > 3000)
                {
                    point.Play();

                    if (lifeCount <= 3)
                    {
                        if (lifeCount == 3)
                        {
                            life.Left = 6000;
                        }
                        if (lifeCount == 2 && manFreeTime > 3000)
                        {
                            h3.Visible = true;
                            lifeCount++;
                            life.Left = 5000;
                        }

                        if (lifeCount == 1 && manFreeTime > 3000)
                        {
                            h2.Visible = true;
                            lifeCount++;
                            life.Left = 4000;
                        }

                        if (lifeCount == 0 && manFreeTime > 3000)
                        {
                            h1.Visible = true;
                            lifeCount++;
                            life.Left = 3000;
                        }
                    }
                }

                lblScore.Text = "Score : " + gameScore;
            }

           
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                man.Top -= gravityUp;
            }
            if (e.KeyCode == Keys.Down)
            {
                man.Top += gravityDown;
            }

            if (e.KeyCode == Keys.Left)
            {
                man.Left -= manMove;
            }

            if (e.KeyCode == Keys.Right)
            {
                man.Left += manMove;
            }

            if (e.KeyCode == Keys.Space)
            {
                boxSpeed = 20; 
            }

            if (e.KeyCode == Keys.ShiftKey && freeVar < 2 && manFreeTime > 3000)
            { 
                freeVar++;
                if(freeVar == 1) 
                {
                    free2.Visible = false;
                }

                if (freeVar == 2)
                {
                    free1.Visible = false;
                }
                manFreeTime = 0;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                boxSpeed = 8;
            }
        }

        private void manFaddingEffect()
        {
            if (man.Visible == true && manFreeTime < 3000)
            {
                man.Visible = false;
            }
            else if (man.Visible == false && manFreeTime < 3000)
            {
                man.Visible = true;
            }
            else
            {
                man.Visible = true;
            }
        }

        private void endGame()
        {
            play.Play();

            timer.Stop();
            pic.Visible = true;
            quit.Visible = true;

            if (gameScore >= target)
            {
                pic.Text = "Wow " + name + "!!!\n\nYou Beat...\n\nYour Score is : " + gameScore;
                pic.Image = Properties.Resources.won4_1;
            }
            else
            {
                pic.Text = "Ohhh " + name + "!!!\n\nYou Lost...\n\nYour Score is : " + gameScore;
            }
            
        }

        private void label14_Click(object sender, EventArgs e)
        {
            play.Stop();
            timer.Enabled = false;
            DialogResult res = MessageBox.Show("Are you sure want to quit the game?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Form1 form1 = new Form1(interval);
                this.Close();
                //form1.Show();
            }
            if (res == DialogResult.Cancel)
            {
                timer.Enabled = true;
            }
        }

        private void ready_Click(object sender, EventArgs e)
        {
            clickOrNot = 1;
        }


        private void screenResolution()
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
        }

        private void targetSelector()
        {
            if (interval == 90)
            {
                target = 1000;
            }

            if (interval == 80)
            {
                target = 2000;
            }

            if (interval == 60)
            {
                target = 3000;
            }
            startLbl.Visible = true;
            startLbl.Text = "Your target is : " + target;
            whetherStartOrNot--;
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {

        }

        private void startLbl_Click(object sender, EventArgs e)
        {

        }

        private void free1_Click(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(interval);
            this.Close();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if((pauseGame%2) == 1)
            {
                timer.Stop();
                gravityDown = 0;
                gravityUp = 0;
                manMove = 0;
            }else
            {
                timer.Start();
                gravityDown = 15;
                gravityUp = 15;
                manMove = 15;
            }
            pauseGame++;
        }

        private void modeSpeed()
        {
            if (interval == 90)
            {
                boxSpeed = 8;
            }

            if (interval == 70)
            {
                boxSpeed = 9;
            }

            if (interval == 60)
            {
                boxSpeed = 10;
            }
        }
    }
}
