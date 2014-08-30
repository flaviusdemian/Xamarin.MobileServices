using System;
using Android.App;
using Android.Content;
using Android.Media;
using PushSharp.Client;
using Xamarin.MobileServices.Android.Helpers;

namespace com.fundora.mobileservices.demo
{
    [Service]
    public class PushHandlerService : PushHandlerServiceBase
    {
        public PushHandlerService() :
            base(Constants.ProjectNumber)
        { }
        protected override void OnMessage(Context context, Intent intent)
        {
            try
            {
                Console.WriteLine("Message successfully received!");
                //Pull out the notification details
                string title = intent.Extras.GetString("alert");
                string message = intent.Extras.GetString("alert");
                //Create a new intent
                intent = new Intent(this, typeof (ChatActivity));
                //Create the notification
                var notification = new Notification(Resource.Drawable.twitter, title);
                notification.Flags = NotificationFlags.AutoCancel;
                notification.Sound = RingtoneManager.GetDefaultUri(RingtoneType.Notification);
                notification.SetLatestEventInfo(this, title, message, PendingIntent.GetActivity(this, 0, intent, 0));
                //Send the notification through the NotificationManager
                var notificationManager = GetSystemService(NotificationService) as NotificationManager;
                notificationManager.Notify(1, notification);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected override void OnRegistered(Context context, string registrationId)
        {
            Console.WriteLine("Push successfully registered!");
            try
            {
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        protected override void OnError(Context context, string errorId)
        {
            Console.WriteLine("Push error: " + errorId);
        }

        protected override void OnUnRegistered(Context context, string registrationId)
        {
            Console.WriteLine("Push unregistered!");
        }
    }
}