namespace BlackjackFormsApp
{
    partial class Settings
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
            this.tb_PlayerAmount = new System.Windows.Forms.TextBox();
            this.tb_DeckAmount = new System.Windows.Forms.TextBox();
            this.tb_StartMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_PlayerAmount
            // 
            this.tb_PlayerAmount.Location = new System.Drawing.Point(225, 84);
            this.tb_PlayerAmount.Name = "tb_PlayerAmount";
            this.tb_PlayerAmount.Size = new System.Drawing.Size(342, 20);
            this.tb_PlayerAmount.TabIndex = 0;
            this.tb_PlayerAmount.Text = "1";
            this.tb_PlayerAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputControlNumbers);
            // 
            // tb_DeckAmount
            // 
            this.tb_DeckAmount.Location = new System.Drawing.Point(225, 119);
            this.tb_DeckAmount.Name = "tb_DeckAmount";
            this.tb_DeckAmount.Size = new System.Drawing.Size(342, 20);
            this.tb_DeckAmount.TabIndex = 1;
            this.tb_DeckAmount.Text = "1";
            this.tb_DeckAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputControlNumbers);
            // 
            // tb_StartMoney
            // 
            this.tb_StartMoney.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb_StartMoney.Location = new System.Drawing.Point(225, 157);
            this.tb_StartMoney.Name = "tb_StartMoney";
            this.tb_StartMoney.Size = new System.Drawing.Size(342, 20);
            this.tb_StartMoney.TabIndex = 2;
            this.tb_StartMoney.Text = "400";
            this.tb_StartMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputControlNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the amount of starting money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter the amount of card decks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the amount of players";
            // 
            // btn_ConfirmSettings
            // 
            this.btn_ConfirmSettings.Location = new System.Drawing.Point(291, 215);
            this.btn_ConfirmSettings.Name = "btn_ConfirmSettings";
            this.btn_ConfirmSettings.Size = new System.Drawing.Size(187, 48);
            this.btn_ConfirmSettings.TabIndex = 6;
            this.btn_ConfirmSettings.Text = "Confirm";
            this.btn_ConfirmSettings.UseVisualStyleBackColor = true;
            this.btn_ConfirmSettings.Click += new System.EventHandler(this.btn_ConfirmSettings_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ConfirmSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_StartMoney);
            this.Controls.Add(this.tb_DeckAmount);
            this.Controls.Add(this.tb_PlayerAmount);
            this.Name = "Settings";
            this.Text = "Blackjack";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputControlNumbers);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_PlayerAmount;
        private System.Windows.Forms.TextBox tb_DeckAmount;
        private System.Windows.Forms.TextBox tb_StartMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmSettings;
    }
}

