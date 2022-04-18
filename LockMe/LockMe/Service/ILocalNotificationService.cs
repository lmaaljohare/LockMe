using System;
using System.Collections.Generic;
using System.Text;

namespace LockMe.Service
{
    public interface ILocalNotificationService
    {
        void LocalNotification(string title, string body, int id, DateTime notifyTime);
        void Cancel(int id);
    }
}
