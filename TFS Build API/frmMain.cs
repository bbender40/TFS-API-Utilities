using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using vars = TFS_Build_API.variables;

namespace TFS_Build_API
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void subMnuConnect_Click(object sender, EventArgs e)
        {
            TeamProjectPicker tpp = new TeamProjectPicker(TeamProjectPickerMode.SingleProject, false);
            tpp.ShowDialog();

            if (tpp.SelectedTeamProjectCollection != null)
            {
                vars.tfsCollection = tpp.SelectedTeamProjectCollection;
                vars.tfsCollection.EnsureAuthenticated();
                vars.proj =  tpp.SelectedProjects[0].ToString();
                mnuUtilities.Enabled = true;
                txtProjectName.Text = "Current Project: " + vars.proj;
                pnlProjectName.Visible = true;
                vars.testManagementService = vars.tfsCollection.GetService<ITestManagementService>();
                vars.teamProject = vars.testManagementService.GetTeamProject(vars.proj);
            }
            else
            {
                MessageBox.Show("You must select a Team Project to continue","No Team Project selected",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void subMnuGetHierarchy_Click(object sender, EventArgs e)
        {
            frmTestPlanInfo frmheirarchy = new frmTestPlanInfo();
            // Set the Parent Form of the Child window.
            frmheirarchy.MdiParent = this;
            // Display the new form.
            frmheirarchy.Show();
            frmheirarchy.WindowState = FormWindowState.Maximized;
            
        }

        private void subMnuWhereUsed_Click(object sender, EventArgs e)
        {
            frmWhereUsed frmwUsed = new frmWhereUsed();
            // Set the Parent Form of the Child window.
            frmwUsed.MdiParent = this;
            // Display the new form.
            frmwUsed.Show();
            frmwUsed.WindowState = FormWindowState.Maximized;
        }

        private void subChangeSetForm_Click(object sender, EventArgs e)
        {
            frmChangesets frmCS = new frmChangesets();
            // Set the Parent Form of the Child window.
            frmCS.MdiParent = this;
            // Display the new form.
            frmCS.Show();
            frmCS.WindowState = FormWindowState.Maximized;
        }
    }
}
