using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockMe.Models
{
    public class HomePageModel
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }
       public Drawable AppIcon { get; set; }
       


        public HomePageModel(string appName, string packageName, Drawable AppIcon)
        {
            AppName = appName;
            PackageName = packageName;
            this.AppIcon = AppIcon;

        }
    }
}
