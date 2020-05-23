namespace Cinema
{
    partial class Cinema_Entrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cinema_Entrance));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Welcome_Message = new System.Windows.Forms.Label();
            this.Get_in = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Here_button = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.online_info_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(236, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 174);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome_Message
            // 
            this.Welcome_Message.AutoSize = true;
            this.Welcome_Message.BackColor = System.Drawing.Color.White;
            this.Welcome_Message.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Message.Location = new System.Drawing.Point(296, 118);
            this.Welcome_Message.Name = "Welcome_Message";
            this.Welcome_Message.Size = new System.Drawing.Size(215, 27);
            this.Welcome_Message.TabIndex = 2;
            this.Welcome_Message.Text = "Welcome to our Cinema!";
            this.Welcome_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Get_in
            // 
            this.Get_in.AutoSize = true;
            this.Get_in.BackColor = System.Drawing.Color.White;
            this.Get_in.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get_in.Location = new System.Drawing.Point(294, 145);
            this.Get_in.Name = "Get_in";
            this.Get_in.Size = new System.Drawing.Size(217, 27);
            this.Get_in.TabIndex = 3;
            this.Get_in.Text = "Please follow me inside,";
            this.Get_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hi! My name is Yao.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Here_button
            // 
            this.Here_button.AutoSize = true;
            this.Here_button.BackColor = System.Drawing.Color.White;
            this.Here_button.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Here_button.Location = new System.Drawing.Point(294, 172);
            this.Here_button.Name = "Here_button";
            this.Here_button.Size = new System.Drawing.Size(168, 27);
            this.Here_button.TabIndex = 5;
            this.Here_button.Text = "by clicking on me!";
            this.Here_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(484, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 670);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // online_info_button
            // 
            this.online_info_button.BackColor = System.Drawing.Color.Transparent;
            this.online_info_button.BackgroundImage = global::Cinema.Properties.Resources.online_info_button1;
            this.online_info_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.online_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.online_info_button.ForeColor = System.Drawing.Color.Transparent;
            this.online_info_button.Location = new System.Drawing.Point(1031, 2);
            this.online_info_button.Name = "online_info_button";
            this.online_info_button.Size = new System.Drawing.Size(51, 50);
            this.online_info_button.TabIndex = 6;
            this.online_info_button.UseVisualStyleBackColor = false;
            this.online_info_button.Click += new System.EventHandler(this.Online_info_button_Click);
            // 
            // Cinema_Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1084, 811);
            this.Controls.Add(this.online_info_button);
            this.Controls.Add(this.Here_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Get_in);
            this.Controls.Add(this.Welcome_Message);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cinema_Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Welcome_Message;
        private System.Windows.Forms.Label Get_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Here_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button online_info_button;
    }
}

