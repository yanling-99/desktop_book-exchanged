namespace desktopAPP
{
    partial class sign_up
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
            this.SendutBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.staff_DataSet = new desktopAPP.Staff_DataSet();
            this.staffBS = new System.Windows.Forms.BindingSource(this.components);
            this.staffTA = new desktopAPP.Staff_DataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new desktopAPP.Staff_DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBS)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(269, 296);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 34);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SendutBT
            // 
            this.SendutBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendutBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendutBT.Location = new System.Drawing.Point(154, 295);
            this.SendutBT.Name = "SendutBT";
            this.SendutBT.Size = new System.Drawing.Size(109, 36);
            this.SendutBT.TabIndex = 2;
            this.SendutBT.Text = "Sign up";
            this.SendutBT.UseVisualStyleBackColor = true;
            this.SendutBT.Click += new System.EventHandler(this.SendutBT_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.DarkGray;
            this.idTB.Location = new System.Drawing.Point(154, 105);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(233, 25);
            this.idTB.TabIndex = 4;
            this.idTB.Text = "staff ID";
            this.idTB.Enter += new System.EventHandler(this.idTB_Enter);
            this.idTB.Leave += new System.EventHandler(this.idTB_Leave);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.ForeColor = System.Drawing.Color.DarkGray;
            this.nameTB.Location = new System.Drawing.Point(154, 190);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(233, 25);
            this.nameTB.TabIndex = 6;
            this.nameTB.Text = "name";
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.ForeColor = System.Drawing.Color.DarkGray;
            this.emailTB.Location = new System.Drawing.Point(154, 238);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(233, 25);
            this.emailTB.TabIndex = 8;
            this.emailTB.Text = "e-mail";
            this.emailTB.Enter += new System.EventHandler(this.emailTB_Enter);
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // staff_DataSet
            // 
            this.staff_DataSet.DataSetName = "Staff_DataSet";
            this.staff_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBS
            // 
            this.staffBS.DataMember = "staff";
            this.staffBS.DataSource = this.staff_DataSet;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uid";
            this.dataGridViewTextBoxColumn1.HeaderText = "uid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn3.HeaderText = "email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idComTB
            // 
            this.idComTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idComTB.ForeColor = System.Drawing.Color.DarkGray;
            this.idComTB.Location = new System.Drawing.Point(154, 147);
            this.idComTB.Name = "idComTB";
            this.idComTB.Size = new System.Drawing.Size(233, 25);
            this.idComTB.TabIndex = 9;
            this.idComTB.Text = "staff ID confirm";
            this.idComTB.Enter += new System.EventHandler(this.idComTB_Enter);
            this.idComTB.Leave += new System.EventHandler(this.idComTB_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(217, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "OTEA+";
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idComTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.SendutBT);
            this.Controls.Add(this.cancel);
            this.Name = "sign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff_sign_up";
            this.Load += new System.EventHandler(this.sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button SendutBT;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox emailTB;
        private Staff_DataSet staff_DataSet;
        private System.Windows.Forms.BindingSource staffBS;
        private Staff_DataSetTableAdapters.staffTableAdapter staffTA;
        private Staff_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idComTB;
        private System.Windows.Forms.Label label5;
    }
}