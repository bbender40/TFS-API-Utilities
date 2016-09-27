namespace TFS_Build_API
{
    partial class frmTestPlanInfo
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
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.colTestSuiteTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestCaseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboProjectName = new System.Windows.Forms.ComboBox();
            this.cboTestPlans = new System.Windows.Forms.ComboBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.AllowUserToResizeRows = false;
            this.dgvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestSuiteTitle,
            this.colTestNum,
            this.colTestCaseTitle});
            this.dgvTest.Location = new System.Drawing.Point(1, 42);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.RowHeadersVisible = false;
            this.dgvTest.Size = new System.Drawing.Size(579, 343);
            this.dgvTest.TabIndex = 2;
            // 
            // colTestSuiteTitle
            // 
            this.colTestSuiteTitle.HeaderText = "Test Suite";
            this.colTestSuiteTitle.Name = "colTestSuiteTitle";
            this.colTestSuiteTitle.ReadOnly = true;
            // 
            // colTestNum
            // 
            this.colTestNum.HeaderText = "TestCaseId";
            this.colTestNum.Name = "colTestNum";
            this.colTestNum.ReadOnly = true;
            // 
            // colTestCaseTitle
            // 
            this.colTestCaseTitle.HeaderText = "Title";
            this.colTestCaseTitle.Name = "colTestCaseTitle";
            this.colTestCaseTitle.ReadOnly = true;
            // 
            // cboProjectName
            // 
            this.cboProjectName.FormattingEnabled = true;
            this.cboProjectName.Items.AddRange(new object[] {
            "AccKnowledge",
            "RightTime",
            "M3Link"});
            this.cboProjectName.Location = new System.Drawing.Point(207, 2);
            this.cboProjectName.Name = "cboProjectName";
            this.cboProjectName.Size = new System.Drawing.Size(263, 21);
            this.cboProjectName.TabIndex = 4;
            this.cboProjectName.Visible = false;
            // 
            // cboTestPlans
            // 
            this.cboTestPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTestPlans.FormattingEnabled = true;
            this.cboTestPlans.Location = new System.Drawing.Point(12, 12);
            this.cboTestPlans.Name = "cboTestPlans";
            this.cboTestPlans.Size = new System.Drawing.Size(404, 24);
            this.cboTestPlans.TabIndex = 5;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(446, 12);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(121, 24);
            this.btnGetInfo.TabIndex = 6;
            this.btnGetInfo.Text = "Get Test Cases";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frmTestPlanInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 397);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.cboTestPlans);
            this.Controls.Add(this.cboProjectName);
            this.Controls.Add(this.dgvTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestPlanInfo";
            this.Text = "Get Test Plan Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.ComboBox cboProjectName;
        private System.Windows.Forms.ComboBox cboTestPlans;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestSuiteTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestCaseTitle;
    }
}

