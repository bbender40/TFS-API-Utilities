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

    public partial class frmWhereUsed : Form
    {

        public DataTable tbl;
        public BindingSource src;
        DataRow row;
        DataTable table = new DataTable();

        public frmWhereUsed()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            frmPleaseWait plswait = new frmPleaseWait();

            plswait.Show();

            Application.DoEvents();

            table.Columns.Add("Test Plan", typeof(string));
            table.Columns.Add("Test Suite", typeof(string));

            int testCaseId;

            testCaseId = Convert.ToInt32(textBox1.Text);

            foreach (ITestPlan testPlan in vars.teamProject.TestPlans.Query("SELECT * from TestPlan"))
            {
                //Check if the test case is present in the plan
                if (testPlan.RootSuite.AllTestCases.Where(tc => tc.Id == testCaseId).Count() > 0)
                {
                    //If the test case is present, dig deeper to find the suite(s) where it is present
                    FindInSuites(testPlan.RootSuite, testCaseId);


                }
            }


            //tbl = table;

            plswait.Close();

            dgvWhereUsed.DataSource = table; //tbl;
            dgvWhereUsed.Sort(dgvWhereUsed.Columns[0], ListSortDirection.Ascending);
            dgvWhereUsed.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvWhereUsed.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void FindInSuites(IStaticTestSuite testSuite, int testCaseId)
        {

            bool test;
            IStaticTestSuite currentSuite = testSuite;
            List<string> path = new List<string>();
            string suitePath = "";

            foreach (ITestSuiteEntry entry in testSuite.Entries)
            {
                row = table.NewRow();

                if (entry.EntryType == TestSuiteEntryType.TestCase)
                {
                    if (entry.Id == testCaseId)
                    {
                        path.Add(testSuite.Title);
                        while (!currentSuite.IsRoot)
                        {
                            currentSuite = currentSuite.Parent;
                            path.Add(currentSuite.Title.ToString());
                        }
                        path.Reverse();

                        foreach(string pathfmt in path)
                        {
                            suitePath = suitePath + " --> " + pathfmt;
                        }

                        row["Test Plan"] = testSuite.Plan.Name;
                        row["Test Suite"] = suitePath; //testSuite.Title;
                        
                        //Console.WriteLine(test.ToString());
                        table.Rows.Add(row);
                    }
                }
                else
                {
                    IStaticTestSuite staticSuite = entry.TestObject as IStaticTestSuite;

                    if (staticSuite != null)
                    {
                        //Console.WriteLine("Test suite Id : {0}, Test suite title : {1}, Test plan Name : {2}", staticSuite.Id, staticSuite.Title, staticSuite.Parent.Title);
                        FindInSuites(staticSuite, testCaseId);
                    }
                    else
                    {
                        //Check in query based or requirement based suites which cannot contain another suite as child
                        IDynamicTestSuiteBase dynamicSuite = entry.TestObject as IDynamicTestSuiteBase;
                        if (dynamicSuite != null)
                        {
                            if (dynamicSuite.TestCases.Where(tc => tc.Id == testCaseId).Count() > 0)
                            {
                                row["Test Plan"] = testSuite.Plan.Name;
                                row["Test Suite"] = testSuite.Title;
                                //Console.WriteLine("Test suite Id : {0}, Test suite title : {1}, Test plan id : {2}", dynamicSuite.Id, dynamicSuite.Title, dynamicSuite.Plan.Id);
                                table.Rows.Add(row);
                            }
                        }
                    }
                }
            }


        }
    }
}
