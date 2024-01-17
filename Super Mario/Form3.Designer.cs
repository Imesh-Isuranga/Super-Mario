namespace Super_Mario
{
    partial class Form3
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
            this.easy = new System.Windows.Forms.Label();
            this.normal = new System.Windows.Forms.Label();
            this.hard = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Gainsboro;
            this.easy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.Location = new System.Drawing.Point(385, 135);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(280, 74);
            this.easy.TabIndex = 0;
            this.easy.Text = "Easy";
            this.easy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.easy.Click += new System.EventHandler(this.label1_Click);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.Color.Gainsboro;
            this.normal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normal.Location = new System.Drawing.Point(385, 237);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(280, 74);
            this.normal.TabIndex = 1;
            this.normal.Text = "Normal";
            this.normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.normal.Click += new System.EventHandler(this.normal_Click);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Gainsboro;
            this.hard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.Location = new System.Drawing.Point(385, 335);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(280, 74);
            this.hard.TabIndex = 2;
            this.hard.Text = "Hard";
            this.hard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(225, 42);
            this.label14.TabIndex = 14;
            this.label14.Text = "<< Go Back";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.BackgroundImage = global::Super_Mario.Properties.Resources._14_1;
            this.ClientSize = new System.Drawing.Size(1185, 586);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.easy);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label easy;
        private System.Windows.Forms.Label normal;
        private System.Windows.Forms.Label hard;
        private System.Windows.Forms.Label label14;
    }
}