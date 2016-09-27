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
    public partial class frmTestPlanInfo : Form
    {
        vars planVars = new vars();
        //public ComboBox cboTP
        //{
        //    get { return this.cboTestPlans; }
        //}

        public frmTestPlanInfo()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
                ContextMenuStrip mnu = new ContextMenuStrip();
                ToolStripMenuItem mnuCopy = new ToolStripMenuItem("Copy");
                ToolStripMenuItem mnuCut = new ToolStripMenuItem("Cut");
                ToolStripMenuItem mnuPaste = new ToolStripMenuItem("Paste");
                //Assign event handlers
                //mnuCopy.Click += new EventHandler(mnuCopy_Click);
                //mnuCut.Click += new EventHandler(mnuCut_Click);
                //mnuPaste.Click += new EventHandler(mnuPaste_Click);
                //Add to main context menu
                mnu.Items.AddRange(new ToolStripItem[] { mnuCopy, mnuCut, mnuPaste });
                //Assign to datagridview
                dgvTest.ContextMenuStrip = mnu;
                FillInTestPlans();
           // }

        }


        private void FillInTestPlans()
        {
            
            ITestPlanCollection plans = vars.teamProject.TestPlans.Query("Select * from TestPlan Order By [PlanName] Asc");

            Dictionary<int, string> testForCbo = new Dictionary<int, string>();

            foreach (ITestPlan plan in plans)
            {
                testForCbo.Add(plan.Id, plan.Name);

            }
            
            cboTestPlans.DataSource = new BindingSource(testForCbo, null);
            cboTestPlans.DisplayMember = "Value";
            cboTestPlans.ValueMember = "Key";
        }


        //private void cboProjectName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //teamProject = testManagementService.GetTeamProject(cboProjectName.SelectedItem.ToString());

        //    //ITestPlanCollection plans = teamProject.TestPlans.Query("Select * from TestPlan Order By [PlanName] Asc");

        //    //Dictionary<int,string> testForCbo = new Dictionary<int,string>();

        //    //foreach (ITestPlan plan in plans)
        //    //{
        //    //    testForCbo.Add(plan.Id, plan.Name);
                
        //    //}

        //    //cboTestPlans.DataSource = new BindingSource(testForCbo, null);
        //    //cboTestPlans.DisplayMember = "Value";
        //    //cboTestPlans.ValueMember = "Key";
        //}

        private void button1_Click_2(object sender, EventArgs e)
        {
            dgvTest.Rows.Clear();
            int testPlanID = 0;

            if (string.IsNullOrEmpty(cboTestPlans.Text))
            {
                MessageBox.Show("Select a TFS Team Project before continuing", "No Team Project selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                testPlanID = Convert.ToInt32(cboTestPlans.SelectedValue);

                ITestPlan plan = vars.teamProject.TestPlans.Find(testPlanID);

                foreach (ITestSuiteBase suite in plan.RootSuite.SubSuites)
                {
                    ITestCaseCollection col = suite.AllTestCases;

                    string testSt = suite.Title;
                    Console.WriteLine("\tTest Suite: {0}", suite.Title);

                    foreach (ITestCase test in col)
                    {
                        //Console.WriteLine("{0},{1},{2}", suite.Title, test.Id, test.Title);
                        dgvTest.Rows.Add(testSt, test.Id, test.Title);
                    }

                }
            }

            dgvTest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvTest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        
    }
}
