using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomationDemoQA.Utitlities
{
    class ProjectPath
    {
        //to get project path Dynamically
        public static string getProjectPath()
        {
            string path = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
            return path;
        }
    }
}
