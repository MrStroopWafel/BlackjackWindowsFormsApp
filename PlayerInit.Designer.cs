namespace BlackjackFormsApp
{
    partial class PlayerInit
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
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmUsername = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(227, 82);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(342, 20);
            this.tb_Username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter your username";
            // 
            // btn_ConfirmUsername
            // 
            this.btn_ConfirmUsername.Location = new System.Drawing.Point(294, 144);
            this.btn_ConfirmUsername.Name = "btn_ConfirmUsername";
            this.btn_ConfirmUsername.Size = new System.Drawing.Size(187, 48);
            this.btn_ConfirmUsername.TabIndex = 7;
            this.btn_ConfirmUsername.Text = "Confirm";
            this.btn_ConfirmUsername.UseVisualStyleBackColor = true;
            this.btn_ConfirmUsername.Click += new System.EventHandler(this.btn_ConfirmUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // PlayerInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConfirmUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Username);
            this.Name = "PlayerInit";
            this.Text = "PlayerInit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmUsername;
        private System.Windows.Forms.Label label1;
    }
}