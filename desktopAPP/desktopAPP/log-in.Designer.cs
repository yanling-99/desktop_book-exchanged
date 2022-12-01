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
            this.label1 = new System.Windows.Forms.Label();
            this.SendutBT = new System.Windows.Forms.Button();
            this.staff_DataSet = new desktopAPP.Staff_DataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTA = new desktopAPP.Staff_DataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new desktopAPP.Staff_DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(129, 234);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(233, 34);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(129, 116);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(233, 25);
            this.idTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // SendutBT
            // 
            this.SendutBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendutBT.Location = new System.Drawing.Point(129, 180);
            this.SendutBT.Name = "SendutBT";
            this.SendutBT.Size = new System.Drawing.Size(233, 36);
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
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 413);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendutBT;
        private Staff_DataSet staff_DataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Staff_DataSetTableAdapters.staffTableAdapter staffTA;
        private Staff_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}