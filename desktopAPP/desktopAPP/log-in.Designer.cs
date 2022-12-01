namespace desktopAPP
{
    partial class log_in
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
            this.components = new System.ComponentModel.Container();
            this.cancel = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.SendutBT = new System.Windows.Forms.Button();
            this.staff_DataSet = new desktopAPP.Staff_DataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTA = new desktopAPP.Staff_DataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new desktopAPP.Staff_DataSetTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(232, 207);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 34);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.DarkGray;
            this.idTB.Location = new System.Drawing.Point(116, 153);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(241, 25);
            this.idTB.TabIndex = 8;
            this.idTB.Text = "Please enter yout staff ID";
            this.idTB.Enter += new System.EventHandler(this.idTB_Enter);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // SendutBT
            // 
            this.SendutBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendutBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendutBT.Location = new System.Drawing.Point(133, 207);
            this.SendutBT.Name = "SendutBT";
            this.SendutBT.Size = new System.Drawing.Size(93, 34);
            this.SendutBT.TabIndex = 6;
            this.SendutBT.Text = "Log in";
            this.SendutBT.UseVisualStyleBackColor = true;
            this.SendutBT.Click += new System.EventHandler(this.SendutBT_Click);
            // 
            // staff_DataSet
            // 
            this.staff_DataSet.DataSetName = "Staff_DataSet";
            this.staff_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.staff_DataSet;
            // 
            // staffTA
            // 
            this.staffTA.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.staffTableAdapter = this.staffTA;
            this.tableAdapterManager.UpdateOrder = desktopAPP.Staff_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(179, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "OTEA+";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(477, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.SendutBT);
            this.Controls.Add(this.cancel);
            this.Name = "log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff_log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button SendutBT;
        private Staff_DataSet staff_DataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Staff_DataSetTableAdapters.staffTableAdapter staffTA;
        private Staff_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label2;
    }
}