namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            Ball = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IMG_0013;
            pictureBox1.Location = new Point(-1, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(15, 143);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += GameTimer;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IMG_0013;
            pictureBox2.Location = new Point(1006, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 143);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Ball
            // 
            Ball.AccessibleName = "";
            Ball.BackColor = SystemColors.ActiveCaptionText;
            Ball.Location = new Point(485, 224);
            Ball.Name = "Ball";
            Ball.Size = new Size(20, 20);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            Ball.Click += Ball_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 109);
            label1.Name = "label1";
            label1.Size = new Size(32, 38);
            label1.TabIndex = 3;
            label1.Text = "0";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(614, 109);
            label2.Name = "label2";
            label2.Size = new Size(32, 38);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 534);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ball);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox Ball;
        private Label label1;
        private Label label2;
    }
}
