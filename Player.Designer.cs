namespace BlackjackFormsApp
{
    partial class Player
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Hit = new System.Windows.Forms.Button();
            this.btn_Stand = new System.Windows.Forms.Button();
            this.btn_Double = new System.Windows.Forms.Button();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_Hit
            // 
            this.btn_Hit.Location = new System.Drawing.Point(167, 321);
            this.btn_Hit.Name = "btn_Hit";
            this.btn_Hit.Size = new System.Drawing.Size(134, 82);
            this.btn_Hit.TabIndex = 1;
            this.btn_Hit.Text = "Hit";
            this.btn_Hit.UseVisualStyleBackColor = true;
            this.btn_Hit.Click += new System.EventHandler(this.btn_Hit_Click);
            // 
            // btn_Stand
            // 
            this.btn_Stand.Location = new System.Drawing.Point(307, 321);
            this.btn_Stand.Name = "btn_Stand";
            this.btn_Stand.Size = new System.Drawing.Size(134, 82);
            this.btn_Stand.TabIndex = 2;
            this.btn_Stand.Text = "Stand";
            this.btn_Stand.UseVisualStyleBackColor = true;
            this.btn_Stand.Click += new System.EventHandler(this.btn_Stand_Click);
            // 
            // btn_Double
            // 
            this.btn_Double.Location = new System.Drawing.Point(447, 321);
            this.btn_Double.Name = "btn_Double";
            this.btn_Double.Size = new System.Drawing.Size(134, 82);
            this.btn_Double.TabIndex = 3;
            this.btn_Double.Text = "Double";
            this.btn_Double.UseVisualStyleBackColor = true;
            this.btn_Double.Click += new System.EventHandler(this.btn_Double_Click);
            // 
            // btn_Continue
            // 
            this.btn_Continue.Location = new System.Drawing.Point(307, 321);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(134, 82);
            this.btn_Continue.TabIndex = 4;
            this.btn_Continue.Text = "Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Visible = false;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.btn_Double);
            this.Controls.Add(this.btn_Stand);
            this.Controls.Add(this.btn_Hit);
            this.Controls.Add(this.label1);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hit;
        private System.Windows.Forms.Button btn_Stand;
        private System.Windows.Forms.Button btn_Double;
        private System.Windows.Forms.Button btn_Continue;
    }
}