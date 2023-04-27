namespace FlagDefaultDrawingTitles2023
{
    partial class frmViewsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dg_views = new System.Windows.Forms.DataGridView();
            this.sheetNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_views)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a row and click Update to change the view name. When finished, click Save " +
    "Changes.";
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(632, 416);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 34);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(541, 416);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 34);
            this.btn_update.TabIndex = 20;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dg_views
            // 
            this.dg_views.AllowUserToAddRows = false;
            this.dg_views.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_views.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_views.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_views.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sheetNum,
            this.viewType,
            this.viewName,
            this.Id});
            this.dg_views.Location = new System.Drawing.Point(13, 46);
            this.dg_views.Name = "dg_views";
            this.dg_views.ReadOnly = true;
            this.dg_views.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_views.Size = new System.Drawing.Size(694, 355);
            this.dg_views.TabIndex = 22;
            // 
            // sheetNum
            // 
            this.sheetNum.HeaderText = "Sheet #";
            this.sheetNum.MinimumWidth = 50;
            this.sheetNum.Name = "sheetNum";
            this.sheetNum.ReadOnly = true;
            // 
            // viewType
            // 
            this.viewType.HeaderText = "View Type";
            this.viewType.Name = "viewType";
            this.viewType.ReadOnly = true;
            this.viewType.Width = 150;
            // 
            // viewName
            // 
            this.viewName.HeaderText = "View Name";
            this.viewName.Name = "viewName";
            this.viewName.ReadOnly = true;
            this.viewName.Width = 400;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmViewsForm
            // 
            this.AcceptButton = this.btn_update;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(719, 462);
            this.Controls.Add(this.dg_views);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Default Named Views";
            ((System.ComponentModel.ISupportInitialize)(this.dg_views)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dg_views;
        private System.Windows.Forms.DataGridViewTextBoxColumn sheetNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewType;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}