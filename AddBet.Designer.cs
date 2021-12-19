namespace BlackjackFormsApp
{
    partial class AddBet
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
            this.btn_ConfirmBet = new System.Windows.Forms.Button();
            this.tb_BetAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ConfirmBet
            // 
            this.btn_ConfirmBet.Location = new System.Drawing.Point(326, 137);
            this.btn_ConfirmBet.Name = "btn_ConfirmBet";
            this.btn_ConfirmBet.Size = new System.Drawing.Size(134, 38);
            this.btn_ConfirmBet.TabIndex = 5;
            this.btn_ConfirmBet.Text = "Confirm";
            this.btn_ConfirmBet.UseVisualStyleBackColor = true;
            this.btn_ConfirmBet.Click += new System.EventHandler(this.btn_ConfirmBet_Click);
            // 
            // tb_BetAmount
            // 
            this.tb_BetAmount.Location = new System.Drawing.Point(269, 96);
            this.tb_BetAmount.Name = "tb_BetAmount";
            this.tb_BetAmount.Size = new System.Drawing.Size(254, 20);
            this.tb_BetAmount.TabIndex = 4;
            this.tb_BetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputControlNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // AddBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ConfirmBet);
            this.Controls.Add(this.tb_BetAmount);
            this.Controls.Add(this.label1);
            this.Name = "AddBet";
            this.Text = "AddBet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ConfirmBet;
        private System.Windows.Forms.TextBox tb_BetAmount;
        private System.Windows.Forms.Label label1;
    }
}