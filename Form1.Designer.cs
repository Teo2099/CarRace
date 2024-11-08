
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gas = new System.Windows.Forms.PictureBox();
            this.explosion1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.house = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Car3 = new System.Windows.Forms.PictureBox();
            this.Car2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.Brown;
            this.stop.Location = new System.Drawing.Point(229, 269);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(402, 69);
            this.stop.TabIndex = 8;
            this.stop.Text = "GAME OVER";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(68, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 58);
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Value = 100;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(68, 64);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(271, 63);
            this.progressBar2.TabIndex = 31;
            this.progressBar2.Value = 100;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.fuelstation__2_;
            this.pictureBox6.Location = new System.Drawing.Point(-3, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 63);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // gas
            // 
            this.gas.Image = global::WindowsFormsApp1.Properties.Resources.gas1;
            this.gas.Location = new System.Drawing.Point(234, 189);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(72, 63);
            this.gas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gas.TabIndex = 32;
            this.gas.TabStop = false;
            // 
            // explosion1
            // 
            this.explosion1.Image = ((System.Drawing.Image)(resources.GetObject("explosion1.Image")));
            this.explosion1.Location = new System.Drawing.Point(428, 374);
            this.explosion1.Name = "explosion1";
            this.explosion1.Size = new System.Drawing.Size(90, 101);
            this.explosion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion1.TabIndex = 30;
            this.explosion1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(504, 99);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(36, 30);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 29;
            this.heart2.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(269, 618);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(37, 34);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 27;
            this.heart1.TabStop = false;
            // 
            // tree2
            // 
            this.tree2.Image = ((System.Drawing.Image)(resources.GetObject("tree2.Image")));
            this.tree2.Location = new System.Drawing.Point(718, 269);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(100, 132);
            this.tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree2.TabIndex = 25;
            this.tree2.TabStop = false;
            // 
            // house
            // 
            this.house.Image = ((System.Drawing.Image)(resources.GetObject("house.Image")));
            this.house.Location = new System.Drawing.Point(-3, 213);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(110, 136);
            this.house.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house.TabIndex = 24;
            this.house.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox5.Location = new System.Drawing.Point(129, -12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 739);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.pictureBox4.Location = new System.Drawing.Point(682, -12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 739);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox2.Location = new System.Drawing.Point(682, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 706);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 706);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Car3
            // 
            this.Car3.Image = ((System.Drawing.Image)(resources.GetObject("Car3.Image")));
            this.Car3.Location = new System.Drawing.Point(565, -35);
            this.Car3.Name = "Car3";
            this.Car3.Size = new System.Drawing.Size(90, 120);
            this.Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car3.TabIndex = 7;
            this.Car3.TabStop = false;
            // 
            // Car2
            // 
            this.Car2.Image = ((System.Drawing.Image)(resources.GetObject("Car2.Image")));
            this.Car2.Location = new System.Drawing.Point(428, 258);
            this.Car2.Name = "Car2";
            this.Car2.Size = new System.Drawing.Size(90, 110);
            this.Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car2.TabIndex = 6;
            this.Car2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.Image = ((System.Drawing.Image)(resources.GetObject("Car1.Image")));
            this.Car1.Location = new System.Drawing.Point(172, 474);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(83, 106);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car1.TabIndex = 4;
            this.Car1.TabStop = false;
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(349, 601);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(85, 105);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.line3.Location = new System.Drawing.Point(409, 573);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 216);
            this.line3.TabIndex = 2;
            this.line3.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.line2.Location = new System.Drawing.Point(409, 232);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 216);
            this.line2.TabIndex = 1;
            this.line2.TabStop = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.line1.Location = new System.Drawing.Point(409, -102);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 216);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            this.line1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(808, 708);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.explosion1);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.house);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Car3);
            this.Controls.Add(this.Car2);
            this.Controls.Add(this.Car1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.house)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox Car2;
        private System.Windows.Forms.PictureBox Car3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox house;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox explosion1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox gas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

