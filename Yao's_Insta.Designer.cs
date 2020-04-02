namespace Cinema
{
    partial class Yao_s_Insta
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
            this.Go_Home_Button = new System.Windows.Forms.Button();
            this.online_info_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Go_Home_Button
            // 
            this.Go_Home_Button.BackColor = System.Drawing.Color.Transparent;
            this.Go_Home_Button.BackgroundImage = global::Cinema.Properties.Resources.food_back;
            this.Go_Home_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Go_Home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go_Home_Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Go_Home_Button.Location = new System.Drawing.Point(0, 734);
            this.Go_Home_Button.Name = "Go_Home_Button";
            this.Go_Home_Button.Size = new System.Drawing.Size(83, 80);
            this.Go_Home_Button.TabIndex = 13;
            this.Go_Home_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Go_Home_Button.UseVisualStyleBackColor = false;
            this.Go_Home_Button.Click += new System.EventHandler(this.Go_Home_Button_Click);
            // 
            // online_info_button
            // 
            this.online_info_button.BackColor = System.Drawing.Color.White;
            this.online_info_button.BackgroundImage = global::Cinema.Properties.Resources.online_info_button1;
            this.online_info_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.online_info_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.online_info_button.ForeColor = System.Drawing.Color.White;
            this.online_info_button.Location = new System.Drawing.Point(1021, 12);
            this.online_info_button.Name = "online_info_button";
            this.online_info_button.Size = new System.Drawing.Size(31, 34);
            this.online_info_button.TabIndex = 185;
            this.online_info_button.UseVisualStyleBackColor = false;
            // 
            // Yao_s_Insta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Cinema.Properties.Resources.Insta_Yao1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1084, 811);
            this.Controls.Add(this.online_info_button);
            this.Controls.Add(this.Go_Home_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Yao_s_Insta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yao_s_Insta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Go_Home_Button;
        private System.Windows.Forms.Button online_info_button;
    }
}