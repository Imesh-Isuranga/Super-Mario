namespace Super_Mario
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.life = new System.Windows.Forms.PictureBox();
            this.box4 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.man = new System.Windows.Forms.PictureBox();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.ready = new System.Windows.Forms.Label();
            this.bomb2 = new System.Windows.Forms.PictureBox();
            this.bomb1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.free2 = new System.Windows.Forms.PictureBox();
            this.free1 = new System.Windows.Forms.PictureBox();
            this.quit = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.free2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.free1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 80;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.h3);
            this.panel1.Controls.Add(this.h2);
            this.panel1.Controls.Add(this.h1);
            this.panel1.Location = new System.Drawing.Point(1, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 56);
            this.panel1.TabIndex = 10;
            // 
            // h3
            // 
            this.h3.Image = global::Super_Mario.Properties.Resources.h;
            this.h3.Location = new System.Drawing.Point(121, 3);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(55, 50);
            this.h3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h3.TabIndex = 2;
            this.h3.TabStop = false;
            // 
            // h2
            // 
            this.h2.Image = global::Super_Mario.Properties.Resources.h;
            this.h2.Location = new System.Drawing.Point(62, 3);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(55, 50);
            this.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h2.TabIndex = 1;
            this.h2.TabStop = false;
            // 
            // h1
            // 
            this.h1.Image = global::Super_Mario.Properties.Resources.h;
            this.h1.Location = new System.Drawing.Point(3, 2);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(55, 50);
            this.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h1.TabIndex = 0;
            this.h1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Chocolate;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(791, 516);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(399, 48);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "Score :";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic
            // 
            this.pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.Image = global::Super_Mario.Properties.Resources._14_1;
            this.pic.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.pic.Location = new System.Drawing.Point(157, 9);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(911, 523);
            this.pic.TabIndex = 12;
            this.pic.Text = "label1";
            this.pic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pic.Visible = false;
            this.pic.Click += new System.EventHandler(this.lblEnd_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(0, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 45);
            this.label14.TabIndex = 14;
            this.label14.Text = "<<Quit";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // life
            // 
            this.life.BackColor = System.Drawing.Color.Transparent;
            this.life.Image = global::Super_Mario.Properties.Resources.R__5_;
            this.life.Location = new System.Drawing.Point(718, 312);
            this.life.Name = "life";
            this.life.Size = new System.Drawing.Size(68, 55);
            this.life.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life.TabIndex = 3;
            this.life.TabStop = false;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.Transparent;
            this.box4.Image = global::Super_Mario.Properties.Resources.R__6_;
            this.box4.Location = new System.Drawing.Point(998, 252);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(143, 132);
            this.box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box4.TabIndex = 5;
            this.box4.TabStop = false;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.Transparent;
            this.box2.Image = global::Super_Mario.Properties.Resources.R__6_;
            this.box2.Location = new System.Drawing.Point(480, 48);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(100, 87);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box2.TabIndex = 3;
            this.box2.TabStop = false;
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.Color.Transparent;
            this.man.BackgroundImage = global::Super_Mario.Properties.Resources.R__8_;
            this.man.Image = global::Super_Mario.Properties.Resources.R__8_;
            this.man.Location = new System.Drawing.Point(4, 398);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(162, 106);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.man.TabIndex = 2;
            this.man.TabStop = false;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.Transparent;
            this.box1.Image = global::Super_Mario.Properties.Resources.R__6_;
            this.box1.Location = new System.Drawing.Point(419, 408);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(69, 59);
            this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            // 
            // startLbl
            // 
            this.startLbl.BackColor = System.Drawing.Color.PaleGreen;
            this.startLbl.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLbl.ForeColor = System.Drawing.Color.Red;
            this.startLbl.Image = global::Super_Mario.Properties.Resources._14_1;
            this.startLbl.Location = new System.Drawing.Point(225, 114);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(761, 309);
            this.startLbl.TabIndex = 15;
            this.startLbl.Text = "label1";
            this.startLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startLbl.Visible = false;
            this.startLbl.Click += new System.EventHandler(this.startLbl_Click);
            // 
            // ready
            // 
            this.ready.BackColor = System.Drawing.Color.DodgerBlue;
            this.ready.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ready.ForeColor = System.Drawing.SystemColors.Control;
            this.ready.Location = new System.Drawing.Point(430, 343);
            this.ready.Name = "ready";
            this.ready.Size = new System.Drawing.Size(336, 51);
            this.ready.TabIndex = 16;
            this.ready.Text = "I\'m Ready";
            this.ready.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ready.Click += new System.EventHandler(this.ready_Click);
            // 
            // bomb2
            // 
            this.bomb2.BackColor = System.Drawing.Color.Transparent;
            this.bomb2.Image = global::Super_Mario.Properties.Resources.bomb;
            this.bomb2.Location = new System.Drawing.Point(1137, 113);
            this.bomb2.Name = "bomb2";
            this.bomb2.Size = new System.Drawing.Size(62, 54);
            this.bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb2.TabIndex = 17;
            this.bomb2.TabStop = false;
            // 
            // bomb1
            // 
            this.bomb1.BackColor = System.Drawing.Color.Transparent;
            this.bomb1.Image = global::Super_Mario.Properties.Resources.bomb;
            this.bomb1.Location = new System.Drawing.Point(-3, 252);
            this.bomb1.Name = "bomb1";
            this.bomb1.Size = new System.Drawing.Size(62, 54);
            this.bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomb1.TabIndex = 18;
            this.bomb1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chocolate;
            this.panel2.Controls.Add(this.free2);
            this.panel2.Controls.Add(this.free1);
            this.panel2.Location = new System.Drawing.Point(430, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 56);
            this.panel2.TabIndex = 11;
            // 
            // free2
            // 
            this.free2.Image = global::Super_Mario.Properties.Resources._1111111;
            this.free2.Location = new System.Drawing.Point(62, 3);
            this.free2.Name = "free2";
            this.free2.Size = new System.Drawing.Size(55, 50);
            this.free2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.free2.TabIndex = 1;
            this.free2.TabStop = false;
            // 
            // free1
            // 
            this.free1.Image = global::Super_Mario.Properties.Resources._1111111;
            this.free1.Location = new System.Drawing.Point(3, 2);
            this.free1.Name = "free1";
            this.free1.Size = new System.Drawing.Size(55, 50);
            this.free1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.free1.TabIndex = 0;
            this.free1.TabStop = false;
            this.free1.Click += new System.EventHandler(this.free1_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.DodgerBlue;
            this.quit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit.ForeColor = System.Drawing.SystemColors.Control;
            this.quit.Location = new System.Drawing.Point(430, 454);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(336, 51);
            this.quit.TabIndex = 19;
            this.quit.Text = "Quit";
            this.quit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quit.Visible = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(39, 66);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(47, 45);
            this.pause.TabIndex = 20;
            this.pause.Text = "||";
            this.pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1191, 564);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.ready);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.life);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.man);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.bomb2);
            this.Controls.Add(this.bomb1);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.free2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.free1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.PictureBox box4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox h3;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox life;
        private System.Windows.Forms.Label pic;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label ready;
        private System.Windows.Forms.PictureBox bomb2;
        private System.Windows.Forms.PictureBox bomb1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox free2;
        private System.Windows.Forms.PictureBox free1;
        private System.Windows.Forms.Label quit;
        private System.Windows.Forms.Label pause;
    }
}