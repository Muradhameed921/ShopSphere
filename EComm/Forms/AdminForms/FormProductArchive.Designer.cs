namespace EComm.Forms.AdminForms
{
    partial class FormProductArchive
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkUserArchive = new System.Windows.Forms.LinkLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Archive";
            // 
            // LinkUserArchive
            // 
            this.LinkUserArchive.AutoSize = true;
            this.LinkUserArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(177)))), ((int)(((byte)(240)))));
            this.LinkUserArchive.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkUserArchive.LinkColor = System.Drawing.Color.Black;
            this.LinkUserArchive.Location = new System.Drawing.Point(295, 30);
            this.LinkUserArchive.Name = "LinkUserArchive";
            this.LinkUserArchive.Size = new System.Drawing.Size(212, 45);
            this.LinkUserArchive.TabIndex = 2;
            this.LinkUserArchive.TabStop = true;
            this.LinkUserArchive.Text = "Users Archive";
            this.LinkUserArchive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUserArchive_LinkClicked);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.DataGridViewProducts);
            this.guna2Panel1.Location = new System.Drawing.Point(35, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(760, 413);
            this.guna2Panel1.TabIndex = 7;
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.AllowUserToAddRows = false;
            this.DataGridViewProducts.AllowUserToDeleteRows = false;
            this.DataGridViewProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.DataGridViewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewProducts.ColumnHeadersHeight = 40;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Cashier,
            this.Total});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewProducts.EnableHeadersVisualStyles = false;
            this.DataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewProducts.Location = new System.Drawing.Point(1, 1);
            this.DataGridViewProducts.MultiSelect = false;
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.ReadOnly = true;
            this.DataGridViewProducts.RowHeadersVisible = false;
            this.DataGridViewProducts.RowHeadersWidth = 62;
            this.DataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewProducts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewProducts.RowTemplate.Height = 40;
            this.DataGridViewProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewProducts.Size = new System.Drawing.Size(758, 411);
            this.DataGridViewProducts.TabIndex = 5;
            this.DataGridViewProducts.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewProducts.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridViewProducts.ThemeStyle.ReadOnly = true;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.Height = 40;
            this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.DataGridViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Name";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cashier
            // 
            this.Cashier.HeaderText = "Category";
            this.Cashier.MinimumWidth = 8;
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Price";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FormProductArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.LinkUserArchive);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProductArchive";
            this.Size = new System.Drawing.Size(833, 528);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkUserArchive;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2DataGridView DataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
