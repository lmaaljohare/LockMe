using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LockMe.Models
{
    public class HomePageModel
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }

        public bool IsChecked { get; set; }
        public ICommand CheckedCommand { get; set; }


        public HomePageModel(string appName, string packageName)
        {
            AppName = appName;
            PackageName = packageName;

        }
    }
}
