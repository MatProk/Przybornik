namespace Przybornik
{
    partial class Paint
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
            this.canvas = new System.Windows.Forms.Panel();
            this.kolory = new System.Windows.Forms.Panel();
            this.pinkBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.blueBox = new System.Windows.Forms.PictureBox();
            this.redBox = new System.Windows.Forms.PictureBox();
            this.blackBox = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.kolory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Controls.Add(this.kolory);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1029, 532);
            this.canvas.TabIndex = 0;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // kolory
            // 
            this.kolory.BackColor = System.Drawing.Color.Gray;
            this.kolory.Controls.Add(this.pinkBox);
            this.kolory.Controls.Add(this.orangeBox);
            this.kolory.Controls.Add(this.greenBox);
            this.kolory.Controls.Add(this.blueBox);
            this.kolory.Controls.Add(this.redBox);
            this.kolory.Controls.Add(this.blackBox);
            this.kolory.Location = new System.Drawing.Point(12, 12);
            this.kolory.Name = "kolory";
            this.kolory.Size = new System.Drawing.Size(217, 36);
            this.kolory.TabIndex = 0;
            // 
            // pinkBox
            // 
            this.pinkBox.BackColor = System.Drawing.Color.Pink;
            this.pinkBox.Location = new System.Drawing.Point(183, 3);
            this.pinkBox.Name = "pinkBox";
            this.pinkBox.Size = new System.Drawing.Size(30, 30);
            this.pinkBox.TabIndex = 6;
            this.pinkBox.TabStop = false;
            this.pinkBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.BackColor = System.Drawing.Color.Orange;
            this.orangeBox.Location = new System.Drawing.Point(147, 3);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(30, 30);
            this.orangeBox.TabIndex = 5;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // greenBox
            // 
            this.greenBox.BackColor = System.Drawing.Color.Green;
            this.greenBox.Location = new System.Drawing.Point(111, 3);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(30, 30);
            this.greenBox.TabIndex = 4;
            this.greenBox.TabStop = false;
            this.greenBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blueBox
            // 
            this.blueBox.BackColor = System.Drawing.Color.Blue;
            this.blueBox.Location = new System.Drawing.Point(75, 3);
            this.blueBox.Name = "blueBox";
            this.blueBox.Size = new System.Drawing.Size(30, 30);
            this.blueBox.TabIndex = 3;
            this.blueBox.TabStop = false;
            this.blueBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // redBox
            // 
            this.redBox.BackColor = System.Drawing.Color.Red;
            this.redBox.Location = new System.Drawing.Point(39, 3);
            this.redBox.Name = "redBox";
            this.redBox.Size = new System.Drawing.Size(30, 30);
            this.redBox.TabIndex = 2;
            this.redBox.TabStop = false;
            this.redBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // blackBox
            // 
            this.blackBox.BackColor = System.Drawing.Color.Black;
            this.blackBox.Location = new System.Drawing.Point(3, 3);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(30, 30);
            this.blackBox.TabIndex = 1;
            this.blackBox.TabStop = false;
            this.blackBox.Click += new System.EventHandler(this.blackBox_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 532);
            this.Controls.Add(this.canvas);
            this.Name = "Paint";
            this.Text = "Paint";
            this.canvas.ResumeLayout(false);
            this.kolory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pinkBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel kolory;
        private System.Windows.Forms.PictureBox pinkBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.PictureBox blueBox;
        private System.Windows.Forms.PictureBox redBox;
        private System.Windows.Forms.PictureBox blackBox;
    }
}