using LockMe.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LockMe
{
    public interface IAndroidService
    {
        List<HomePageModel> GetIntalledApps();
    }
}
