namespace desktopAPP
{
    partial class Home
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
            this.SighupBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SighupBT
            // 
            this.SighupBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SighupBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SighupBT.Location = new System.Drawing.Point(148, 238);
            this.SighupBT.Name = "SighupBT";
            this.SighupBT.Size = new System.Drawing.Size(133, 36);
            this.SighupBT.TabIndex = 0;
            this.SighupBT.Text = "Sigh up";
            this.SighupBT.UseVisualStyleBackColor = true;
            this.SighupBT.Click += new System.EventHandler(this.SighupBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(84, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "OTEA+";
            // 
            // LoginBT
            // 
            this.LoginBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.Location = new System.Drawing.Point(148, 292);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(133, 36);
            this.LoginBT.TabIndex = 2;
            this.LoginBT.Text = "Log in";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(87, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Used Textbook Trading Platform";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(441, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SighupBT);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SighupBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.Label label2;
    }
}