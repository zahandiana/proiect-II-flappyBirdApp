namespace WinFormsApp9_Project
{
    partial class Form4
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
            label1 = new Label();
            startBtn = new Button();
            button2 = new Button();
            exitBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(224, 90);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "MAIN MENU";
            // 
            // startBtn
            // 
            startBtn.BackgroundImageLayout = ImageLayout.Center;
            startBtn.Cursor = Cursors.No;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            startBtn.Location = new Point(224, 182);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(184, 47);
            startBtn.TabIndex = 1;
            startBtn.Text = "START";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(224, 276);
            button2.Name = "button2";
            button2.Size = new Size(184, 47);
            button2.TabIndex = 2;
            button2.Text = "SETTINGS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Popup;
            exitBtn.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.Location = new Point(224, 365);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(184, 47);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bird;
            pictureBox1.Location = new Point(66, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 62);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ground;
            pictureBox2.Location = new Point(1, 439);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 62);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ground;
            pictureBox3.Location = new Point(336, 439);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(338, 62);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pipe;
            pictureBox4.Location = new Point(520, 249);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 193);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(675, 500);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitBtn);
            Controls.Add(button2);
            Controls.Add(startBtn);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startBtn;
        private Button button2;
        private Button exitBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}