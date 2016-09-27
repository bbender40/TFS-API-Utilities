using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.Build.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using Microsoft.TeamFoundation.TestManagement.Client;

namespace TFS_Build_API
{
    public class variables
    {

        public static TfsTeamProjectCollection tfsCollection { get; set; }
        public static ITestManagementService testManagementService { get; set; }
        public static string proj { get; set; }
        public static ITestManagementTeamProject teamProject { get; set; }

    }
}
