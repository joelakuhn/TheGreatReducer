namespace TheGreatReducer
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.scaleFactor_txt = new System.Windows.Forms.TextBox();
            this.transparent_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.down_btn = new System.Windows.Forms.Button();
            this.right_btn = new System.Windows.Forms.Button();
            this.left_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "select area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(345, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scaleFactor_txt
            // 
            this.scaleFactor_txt.Location = new System.Drawing.Point(241, 5);
            this.scaleFactor_txt.Name = "scaleFactor_txt";
            this.scaleFactor_txt.Size = new System.Drawing.Size(32, 20);
            this.scaleFactor_txt.TabIndex = 3;
            this.scaleFactor_txt.Text = "1.25";
            // 
            // transparent_btn
            // 
            this.transparent_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.transparent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transparent_btn.Location = new System.Drawing.Point(84, 3);
            this.transparent_btn.Name = "transparent_btn";
            this.transparent_btn.Size = new System.Drawing.Size(75, 23);
            this.transparent_btn.TabIndex = 4;
            this.transparent_btn.Text = "hide/show";
            this.transparent_btn.UseVisualStyleBackColor = true;
            this.transparent_btn.Click += new System.EventHandler(this.transparent_btn_Click);
            this.transparent_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.transparent_btn_Down);
            this.transparent_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.transparent_btn_Up);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.up_btn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.down_btn);
            this.panel2.Controls.Add(this.right_btn);
            this.panel2.Controls.Add(this.left_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.scaleFactor_txt);
            this.panel2.Controls.Add(this.transparent_btn);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 29);
            this.panel2.TabIndex = 5;
            // 
            // down_btn
            // 
            this.down_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.down_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_btn.Location = new System.Drawing.Point(287, 16);
            this.down_btn.Name = "down_btn";
            this.down_btn.Size = new System.Drawing.Size(10, 10);
            this.down_btn.TabIndex = 9;
            this.down_btn.UseVisualStyleBackColor = true;
            this.down_btn.Click += new System.EventHandler(this.down_btn_Click);
            // 
            // right_btn
            // 
            this.right_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.right_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right_btn.Location = new System.Drawing.Point(296, 9);
            this.right_btn.Name = "right_btn";
            this.right_btn.Size = new System.Drawing.Size(10, 10);
            this.right_btn.TabIndex = 8;
            this.right_btn.UseVisualStyleBackColor = true;
            this.right_btn.Click += new System.EventHandler(this.right_btn_Click);
            // 
            // left_btn
            // 
            this.left_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.left_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left_btn.Location = new System.Drawing.Point(278, 9);
            this.left_btn.Name = "left_btn";
            this.left_btn.Size = new System.Drawing.Size(10, 10);
            this.left_btn.TabIndex = 7;
            this.left_btn.UseVisualStyleBackColor = true;
            this.left_btn.Click += new System.EventHandler(this.left_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_btn.Location = new System.Drawing.Point(287, 2);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(10, 10);
            this.up_btn.TabIndex = 6;
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scale Factor:";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(316, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(376, 44);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "The Great Reducer";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox scaleFactor_txt;
        private System.Windows.Forms.Button transparent_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button down_btn;
        private System.Windows.Forms.Button right_btn;
        private System.Windows.Forms.Button left_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button button3;
    }
}

