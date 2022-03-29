using LockMe.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Android.Graphics.Drawables;
using System.Collections.Generic;

namespace LockMe.ViewModels
{

    public class HomeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<HomePageModel> installedApps;
        private bool isChecked;
        public ObservableCollection<HomePageModel> InstalledApps
        {
            get { return installedApps; }
            set
            {

                installedApps = value;
            }
        }

        public HomeViewModel()
        {
            List<HomePageModel> listOfInstalledApps = DependencyService.Get<IAndroidService>().GetIntalledApps();
            InstalledApps = new ObservableCollection<HomePageModel>(listOfInstalledApps);
        }

        public event PropertyChangedEventHandler PropertyChanged;





    }
}