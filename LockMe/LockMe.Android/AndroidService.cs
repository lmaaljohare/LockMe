using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using LockMe.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content.PM;
using LockMe.Models;
[assembly: Xamarin.Forms.Dependency(typeof(AndroidService))]
namespace LockMe.Droid
{

    public class AndroidService : IAndroidService
    {
        public static object Drawable { get; internal set; }

        public List<HomePageModel> GetIntalledApps()
        {
            List<HomePageModel> inApps = new List<HomePageModel>();
            IList<ApplicationInfo> apps = Android.App.Application.Context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);
            for (int i = 0; i < apps.Count; i++)



            {
                inApps.Add(new HomePageModel(apps[i].LoadLabel(Android.App.Application.Context.PackageManager), apps[i].PackageName));
            }

            return inApps;


        }


    }


}