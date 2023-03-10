namespace task_2
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
            b1 = new Button();
            img1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)img1).BeginInit();
            SuspendLayout();
            // 
            // b1
            // 
            b1.BackColor = SystemColors.ScrollBar;
            b1.ForeColor = SystemColors.ActiveCaptionText;
            b1.Location = new Point(694, 352);
            b1.Name = "b1";
            b1.Size = new Size(94, 75);
            b1.TabIndex = 0;
            b1.Text = "choos picture\r\n";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // img1
            // 
            img1.Location = new Point(0, 0);
            img1.Name = "img1";
            img1.Size = new Size(556, 438);
            img1.SizeMode = PictureBoxSizeMode.Zoom;
            img1.TabIndex = 1;
            img1.TabStop = false;
            img1.Click += img1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(img1);
            Controls.Add(b1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)img1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private PictureBox img1;
    }
}