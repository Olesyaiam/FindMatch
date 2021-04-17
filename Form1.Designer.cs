
namespace FindMatch
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStep = new System.Windows.Forms.Label();
            this.pictureBoxMini1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMini4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.Location = new System.Drawing.Point(205, 48);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(139, 25);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Text = "начните игру!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Время:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(528, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Кол-во шагов:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindMatch.Properties.Resources.steps;
            this.pictureBox1.InitialImage = global::FindMatch.Properties.Resources.steps;
            this.pictureBox1.Location = new System.Drawing.Point(420, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRestart.BackgroundImage")));
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRestart.Location = new System.Drawing.Point(28, 29);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(73, 69);
            this.buttonRestart.TabIndex = 12;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(609, 402);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(162, 119);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(417, 402);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(162, 119);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Red;
            this.button10.Location = new System.Drawing.Point(227, 402);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(162, 119);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Red;
            this.button9.Location = new System.Drawing.Point(35, 402);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(162, 119);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(609, 267);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 119);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(417, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 119);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(227, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 119);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(35, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 119);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(609, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 119);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(417, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 119);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(227, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 119);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(35, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 119);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStep.Location = new System.Drawing.Point(748, 48);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(23, 25);
            this.labelStep.TabIndex = 17;
            this.labelStep.Text = "0";
            // 
            // pictureBoxMini1
            // 
            this.pictureBoxMini1.Location = new System.Drawing.Point(98, 537);
            this.pictureBoxMini1.Name = "pictureBoxMini1";
            this.pictureBoxMini1.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini1.TabIndex = 18;
            this.pictureBoxMini1.TabStop = false;
            // 
            // pictureBoxMini2
            // 
            this.pictureBoxMini2.Location = new System.Drawing.Point(204, 537);
            this.pictureBoxMini2.Name = "pictureBoxMini2";
            this.pictureBoxMini2.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini2.TabIndex = 19;
            this.pictureBoxMini2.TabStop = false;
            // 
            // pictureBoxMini3
            // 
            this.pictureBoxMini3.Location = new System.Drawing.Point(311, 537);
            this.pictureBoxMini3.Name = "pictureBoxMini3";
            this.pictureBoxMini3.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini3.TabIndex = 20;
            this.pictureBoxMini3.TabStop = false;
            // 
            // pictureBoxMini6
            // 
            this.pictureBoxMini6.Location = new System.Drawing.Point(624, 537);
            this.pictureBoxMini6.Name = "pictureBoxMini6";
            this.pictureBoxMini6.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini6.TabIndex = 23;
            this.pictureBoxMini6.TabStop = false;
            // 
            // pictureBoxMini5
            // 
            this.pictureBoxMini5.Location = new System.Drawing.Point(520, 537);
            this.pictureBoxMini5.Name = "pictureBoxMini5";
            this.pictureBoxMini5.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini5.TabIndex = 22;
            this.pictureBoxMini5.TabStop = false;
            // 
            // pictureBoxMini4
            // 
            this.pictureBoxMini4.Location = new System.Drawing.Point(415, 537);
            this.pictureBoxMini4.Name = "pictureBoxMini4";
            this.pictureBoxMini4.Size = new System.Drawing.Size(83, 64);
            this.pictureBoxMini4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMini4.TabIndex = 21;
            this.pictureBoxMini4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 621);
            this.Controls.Add(this.pictureBoxMini6);
            this.Controls.Add(this.pictureBoxMini5);
            this.Controls.Add(this.pictureBoxMini4);
            this.Controls.Add(this.pictureBoxMini3);
            this.Controls.Add(this.pictureBoxMini2);
            this.Controls.Add(this.pictureBoxMini1);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Найди пару (Жигалова Олеся)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMini4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.PictureBox pictureBoxMini1;
        private System.Windows.Forms.PictureBox pictureBoxMini2;
        private System.Windows.Forms.PictureBox pictureBoxMini3;
        private System.Windows.Forms.PictureBox pictureBoxMini6;
        private System.Windows.Forms.PictureBox pictureBoxMini5;
        private System.Windows.Forms.PictureBox pictureBoxMini4;
    }
}

