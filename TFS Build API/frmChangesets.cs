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
using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.VersionControl.Client;
using vars = TFS_Build_API.variables;

namespace TFS_Build_API
{
    public partial class frmChangesets : Form
    {

       
        public frmChangesets()
        {
            InitializeComponent();
        }

        private void btnGetChangesets_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            DataRow row;

            int numDays = 0;

            table.Columns.Add("Changeset ID", typeof(string));
            table.Columns.Add("Owner", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Comment", typeof(string));

            VersionControlServer vcs = (VersionControlServer)vars.tfsCollection.GetService(typeof(VersionControlServer));

            if(cboCSDateRange.Text == "")
            {
                MessageBox.Show("Please select the number of days to gather changeset data");
                return;
            }
            else
            {
                numDays = Convert.ToInt32(cboCSDateRange.SelectedItem);
            }

            //Following will get all changesets since 20 days. Note : "DateVersionSpec(DateTime.Now - TimeSpan.FromDays(20))"
            System.Collections.IEnumerable history = vcs.QueryHistory("$/" + vars.teamProject, LatestVersionSpec.Instance, 0, RecursionType.Full, null, new DateVersionSpec(DateTime.Now - TimeSpan.FromDays(numDays)), LatestVersionSpec.Instance, Int32.MaxValue, false, false);

            foreach (Changeset changeset in history)
            {

                row = table.NewRow();

                row["Changeset ID"] = changeset.ChangesetId;
                row["Owner"] = changeset.Owner;
                row["Date"] = changeset.CreationDate.ToString();
                row["Comment"] = changeset.Comment;

                //Console.WriteLine("Test suite Id : {0}, Test suite title : {1}, Test plan Name : {2}", testSuite.Id, testSuite.Title, testSuite.Plan.Name);
                table.Rows.Add(row);




                Console.WriteLine("Changeset Id: " + changeset.ChangesetId);
                Console.WriteLine("Owner: " + changeset.Owner);
                Console.WriteLine("Date: " + changeset.CreationDate.ToString());
                Console.WriteLine("Comment: " + changeset.Comment);
                Console.WriteLine("-------------------------------------");
            }

            dgvChangesets.DataSource = table; //tbl;
            dgvChangesets.Sort(dgvChangesets.Columns[0], ListSortDirection.Ascending);
            dgvChangesets.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvChangesets.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvChangesets.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvChangesets.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
    }
