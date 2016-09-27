namespace TFS_Build_API
{
    partial class frmChangesets
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
            this.btnGetChangesets = new System.Windows.Forms.Button();
            this.dgvChangesets = new System.Windows.Forms.DataGridView();
            this.cboCSDateRange = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangesets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetChangesets
            // 
            this.btnGetChangesets.Location = new System.Drawing.Point(164, 10);
            this.btnGetChangesets.Name = "btnGetChangesets";
            this.btnGetChangesets.Size = new System.Drawing.Size(114, 23);
            this.btnGetChangesets.TabIndex = 0;
            this.btnGetChangesets.Text = "Get Changesets";
            this.btnGetChangesets.UseVisualStyleBackColor = true;
            this.btnGetChangesets.Click += new System.EventHandler(this.btnGetChangesets_Click);
            // 
            // dgvChangesets
            // 
            this.dgvChangesets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChangesets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangesets.Location = new System.Drawing.Point(12, 42);
            this.dgvChangesets.Name = "dgvChangesets";
            this.dgvChangesets.Size = new System.Drawing.Size(296, 207);
            this.dgvChangesets.TabIndex = 1;
            // 
            // cboCSDateRange
            // 
            this.cboCSDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCSDateRange.FormattingEnabled = true;
            this.cboCSDateRange.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20"});
            this.cboCSDateRange.Location = new System.Drawing.Point(12, 12);
            this.cboCSDateRange.Name = "cboCSDateRange";
            this.cboCSDateRange.Size = new System.Drawing.Size(121, 24);
            this.cboCSDateRange.TabIndex = 2;
            // 
            // frmChangesets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.Controls.Add(this.cboCSDateRange);
            this.Controls.Add(this.dgvChangesets);
            this.Controls.Add(this.btnGetChangesets);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangesets";
            this.Text = "Find Code Changesets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangesets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetChangesets;
        private System.Windows.Forms.DataGridView dgvChangesets;
        private System.Windows.Forms.ComboBox cboCSDateRange;
    }
}