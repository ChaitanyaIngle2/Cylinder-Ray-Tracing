namespace RayTraceSphere
{
    partial class RayTraceSphere
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.title15 = new System.Windows.Forms.Label();
            this.cam_X_input = new System.Windows.Forms.TextBox();
            this.cam_Y_input = new System.Windows.Forms.TextBox();
            this.cam_Z_input = new System.Windows.Forms.TextBox();
            this.cyl_X_input = new System.Windows.Forms.TextBox();
            this.cyl_Y_input = new System.Windows.Forms.TextBox();
            this.cyl_Z_input = new System.Windows.Forms.TextBox();
            this.cyl_r_input = new System.Windows.Forms.TextBox();
            this.cyl_h_input = new System.Windows.Forms.TextBox();
            this.light_X_input = new System.Windows.Forms.TextBox();
            this.light_Y_input = new System.Windows.Forms.TextBox();
            this.light_Z_input = new System.Windows.Forms.TextBox();
            this.draw_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(275, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 496);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(30, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "radius:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(62, 292);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(62, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(63, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(80, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cylinder Parameters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Camera Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(60, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(62, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(104, 438);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Light Source";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(63, 572);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Z:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(63, 527);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(63, 482);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "X:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(30, 384);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "height:";
            // 
            // title15
            // 
            this.title15.AutoSize = true;
            this.title15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title15.Location = new System.Drawing.Point(421, 24);
            this.title15.Name = "title15";
            this.title15.Size = new System.Drawing.Size(324, 32);
            this.title15.TabIndex = 47;
            this.title15.Text = "Ray Tracing a Cylinder";
            // 
            // cam_X_input
            // 
            this.cam_X_input.Location = new System.Drawing.Point(95, 39);
            this.cam_X_input.Margin = new System.Windows.Forms.Padding(4);
            this.cam_X_input.Name = "cam_X_input";
            this.cam_X_input.Size = new System.Drawing.Size(132, 22);
            this.cam_X_input.TabIndex = 48;
            this.cam_X_input.Text = "200";
            // 
            // cam_Y_input
            // 
            this.cam_Y_input.Location = new System.Drawing.Point(95, 73);
            this.cam_Y_input.Margin = new System.Windows.Forms.Padding(4);
            this.cam_Y_input.Name = "cam_Y_input";
            this.cam_Y_input.Size = new System.Drawing.Size(132, 22);
            this.cam_Y_input.TabIndex = 49;
            this.cam_Y_input.Text = "200";
            // 
            // cam_Z_input
            // 
            this.cam_Z_input.Location = new System.Drawing.Point(95, 107);
            this.cam_Z_input.Margin = new System.Windows.Forms.Padding(4);
            this.cam_Z_input.Name = "cam_Z_input";
            this.cam_Z_input.Size = new System.Drawing.Size(132, 22);
            this.cam_Z_input.TabIndex = 50;
            this.cam_Z_input.Text = "-50";
            // 
            // cyl_X_input
            // 
            this.cyl_X_input.Location = new System.Drawing.Point(95, 202);
            this.cyl_X_input.Margin = new System.Windows.Forms.Padding(4);
            this.cyl_X_input.Name = "cyl_X_input";
            this.cyl_X_input.Size = new System.Drawing.Size(132, 22);
            this.cyl_X_input.TabIndex = 51;
            this.cyl_X_input.Text = "250";
            // 
            // cyl_Y_input
            // 
            this.cyl_Y_input.Location = new System.Drawing.Point(95, 246);
            this.cyl_Y_input.Margin = new System.Windows.Forms.Padding(4);
            this.cyl_Y_input.Name = "cyl_Y_input";
            this.cyl_Y_input.Size = new System.Drawing.Size(132, 22);
            this.cyl_Y_input.TabIndex = 52;
            this.cyl_Y_input.Text = "100";
            // 
            // cyl_Z_input
            // 
            this.cyl_Z_input.Location = new System.Drawing.Point(95, 292);
            this.cyl_Z_input.Margin = new System.Windows.Forms.Padding(4);
            this.cyl_Z_input.Name = "cyl_Z_input";
            this.cyl_Z_input.Size = new System.Drawing.Size(132, 22);
            this.cyl_Z_input.TabIndex = 53;
            this.cyl_Z_input.Text = "100";
            // 
            // cyl_r_input
            // 
            this.cyl_r_input.Location = new System.Drawing.Point(95, 332);
            this.cyl_r_input.Margin = new System.Windows.Forms.Padding(4);
            this.cyl_r_input.Name = "cyl_r_input";
            this.cyl_r_input.Size = new System.Drawing.Size(132, 22);
            this.cyl_r_input.TabIndex = 54;
            this.cyl_r_input.Text = "100";
            // 
            // cyl_h_input
            // 
            this.cyl_h_input.Location = new System.Drawing.Point(95, 379);
            this.cyl_h_input.Margin = new System.Windows.Forms.Padding(4);
            this.cyl_h_input.Name = "cyl_h_input";
            this.cyl_h_input.Size = new System.Drawing.Size(132, 22);
            this.cyl_h_input.TabIndex = 55;
            this.cyl_h_input.Text = "250";
            // 
            // light_X_input
            // 
            this.light_X_input.Location = new System.Drawing.Point(95, 477);
            this.light_X_input.Margin = new System.Windows.Forms.Padding(4);
            this.light_X_input.Name = "light_X_input";
            this.light_X_input.Size = new System.Drawing.Size(132, 22);
            this.light_X_input.TabIndex = 56;
            this.light_X_input.Text = "-50";
            // 
            // light_Y_input
            // 
            this.light_Y_input.Location = new System.Drawing.Point(95, 524);
            this.light_Y_input.Margin = new System.Windows.Forms.Padding(4);
            this.light_Y_input.Name = "light_Y_input";
            this.light_Y_input.Size = new System.Drawing.Size(132, 22);
            this.light_Y_input.TabIndex = 57;
            this.light_Y_input.Text = "-50";
            // 
            // light_Z_input
            // 
            this.light_Z_input.Location = new System.Drawing.Point(95, 569);
            this.light_Z_input.Margin = new System.Windows.Forms.Padding(4);
            this.light_Z_input.Name = "light_Z_input";
            this.light_Z_input.Size = new System.Drawing.Size(132, 22);
            this.light_Z_input.TabIndex = 58;
            this.light_Z_input.Text = "10";
            // 
            // draw_button
            // 
            this.draw_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.draw_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.draw_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_button.Location = new System.Drawing.Point(427, 612);
            this.draw_button.Margin = new System.Windows.Forms.Padding(4);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(100, 28);
            this.draw_button.TabIndex = 59;
            this.draw_button.Text = "DRAW!";
            this.draw_button.UseVisualStyleBackColor = false;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.Firebrick;
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.Location = new System.Drawing.Point(645, 612);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(100, 28);
            this.reset_button.TabIndex = 60;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // RayTraceSphere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(978, 671);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.draw_button);
            this.Controls.Add(this.light_Z_input);
            this.Controls.Add(this.light_Y_input);
            this.Controls.Add(this.light_X_input);
            this.Controls.Add(this.cyl_h_input);
            this.Controls.Add(this.cyl_r_input);
            this.Controls.Add(this.cyl_Z_input);
            this.Controls.Add(this.cyl_Y_input);
            this.Controls.Add(this.cyl_X_input);
            this.Controls.Add(this.cam_Z_input);
            this.Controls.Add(this.cam_Y_input);
            this.Controls.Add(this.cam_X_input);
            this.Controls.Add(this.title15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RayTraceSphere";
            this.Text = "RayTraceCylinder";
            this.Load += new System.EventHandler(this.RayTraceSphere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label title15;
        private System.Windows.Forms.TextBox cam_X_input;
        private System.Windows.Forms.TextBox cam_Y_input;
        private System.Windows.Forms.TextBox cam_Z_input;
        private System.Windows.Forms.TextBox cyl_X_input;
        private System.Windows.Forms.TextBox cyl_Y_input;
        private System.Windows.Forms.TextBox cyl_Z_input;
        private System.Windows.Forms.TextBox cyl_r_input;
        private System.Windows.Forms.TextBox cyl_h_input;
        private System.Windows.Forms.TextBox light_X_input;
        private System.Windows.Forms.TextBox light_Y_input;
        private System.Windows.Forms.TextBox light_Z_input;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Button reset_button;
    }
}

