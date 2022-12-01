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
            this.label1 = new System.Windows.Forms.Label();
            this.SendutBT = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staff_DataSet = new desktopAPP.Staff_DataSet();
            this.staffBS = new System.Windows.Forms.BindingSource(this.components);
            this.staffTA = new desktopAPP.Staff_DataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new desktopAPP.Staff_DataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idComTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staff_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBS)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(178, 323);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(233, 34);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // SendutBT
            // 
            this.SendutBT.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendutBT.Location = new System.Drawing.Point(178, 272);
            this.SendutBT.Name = "SendutBT";
            this.SendutBT.Size = new System.Drawing.Size(233, 36);
            this.SendutBT.TabIndex = 2;
            this.SendutBT.Text = "Sign up";
            this.SendutBT.UseVisualStyleBackColor = true;
            this.SendutBT.Click += new System.EventHandler(this.SendutBT_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.Location = new System.Drawing.Point(178, 74);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(233, 25);
            this.idTB.TabIndex = 4;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(178, 159);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(233, 25);
            this.nameTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.Location = new System.Drawing.Point(178, 207);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(233, 25);
            this.emailTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail:";
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
            this.idComTB.Location = new System.Drawing.Point(178, 116);
            this.idComTB.Name = "idComTB";
            this.idComTB.Size = new System.Drawing.Size(233, 25);
            this.idComTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Confirm:";
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idComTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendutBT;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label3;
        private Staff_DataSet staff_DataSet;
        private System.Windows.Forms.BindingSource staffBS;
        private Staff_DataSetTableAdapters.staffTableAdapter staffTA;
        private Staff_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idComTB;
        private System.Windows.Forms.Label label4;
    }
}