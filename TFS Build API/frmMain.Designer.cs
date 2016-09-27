namespace TFS_Build_API
{
    partial class frmMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.subFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUtilities = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuGetHierarchy = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuWhereUsed = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlProjectName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.subChangeSetForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.pnlProjectName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subFile,
            this.mnuUtilities});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(679, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "File";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFile_ItemClicked);
            // 
            // subFile
            // 
            this.subFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuConnect});
            this.subFile.Name = "subFile";
            this.subFile.Size = new System.Drawing.Size(38, 20);
            this.subFile.Text = "TFS";
            // 
            // subMnuConnect
            // 
            this.subMnuConnect.Name = "subMnuConnect";
            this.subMnuConnect.Size = new System.Drawing.Size(119, 22);
            this.subMnuConnect.Text = "Connect";
            this.subMnuConnect.Click += new System.EventHandler(this.subMnuConnect_Click);
            // 
            // mnuUtilities
            // 
            this.mnuUtilities.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuGetHierarchy,
            this.subMnuWhereUsed,
            this.toolStripSeparator1,
            this.subChangeSetForm});
            this.mnuUtilities.Enabled = false;
            this.mnuUtilities.Name = "mnuUtilities";
            this.mnuUtilities.Size = new System.Drawing.Size(58, 20);
            this.mnuUtilities.Text = "Utilities";
            // 
            // subMnuGetHierarchy
            // 
            this.subMnuGetHierarchy.Name = "subMnuGetHierarchy";
            this.subMnuGetHierarchy.Size = new System.Drawing.Size(189, 22);
            this.subMnuGetHierarchy.Text = "Test Plan Hierarchy";
            this.subMnuGetHierarchy.Click += new System.EventHandler(this.subMnuGetHierarchy_Click);
            // 
            // subMnuWhereUsed
            // 
            this.subMnuWhereUsed.Name = "subMnuWhereUsed";
            this.subMnuWhereUsed.Size = new System.Drawing.Size(189, 22);
            this.subMnuWhereUsed.Text = "Test Case Where Used";
            this.subMnuWhereUsed.Click += new System.EventHandler(this.subMnuWhereUsed_Click);
            // 
            // pnlProjectName
            // 
            this.pnlProjectName.Controls.Add(this.panel1);
            this.pnlProjectName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectName.Location = new System.Drawing.Point(0, 24);
            this.pnlProjectName.Name = "pnlProjectName";
            this.pnlProjectName.Size = new System.Drawing.Size(679, 65);
            this.pnlProjectName.TabIndex = 2;
            this.pnlProjectName.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(302, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 65);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(310, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change";
            // 
            // txtProjectName
            // 
            this.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjectName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectName.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtProjectName.Location = new System.Drawing.Point(28, 15);
            this.txtProjectName.Multiline = true;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.ReadOnly = true;
            this.txtProjectName.Size = new System.Drawing.Size(326, 25);
            this.txtProjectName.TabIndex = 3;
            this.txtProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // subChangeSetForm
            // 
            this.subChangeSetForm.Name = "subChangeSetForm";
            this.subChangeSetForm.Size = new System.Drawing.Size(189, 22);
            this.subChangeSetForm.Text = "Changesets";
            this.subChangeSetForm.Click += new System.EventHandler(this.subChangeSetForm_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 449);
            this.Controls.Add(this.pnlProjectName);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlProjectName.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem subFile;
        private System.Windows.Forms.ToolStripMenuItem subMnuConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuUtilities;
        private System.Windows.Forms.ToolStripMenuItem subMnuGetHierarchy;
        private System.Windows.Forms.ToolStripMenuItem subMnuWhereUsed;
        private System.Windows.Forms.Panel pnlProjectName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem subChangeSetForm;
    }
}