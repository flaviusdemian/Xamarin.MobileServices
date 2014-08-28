using System;
using Android.App;
using Android.Runtime;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.MobileServices.Core;

namespace Xamarin.MobileServices.Android.MyApplication
{
    [Application(Debuggable = true)]
    public class MyApplication : Application
    {
        public static MobileServiceClient MobileService =
            new MobileServiceClient("https://demoflavius.azure-mobile.net/", "BAnpBgjwvAiseBuqYzJohLfKjwSWbD28");

        public static String Channel = null;

        public static readonly IMobileServiceTable<UserEntity> UsersTable = MobileService.GetTable<UserEntity>();
        public static readonly IMobileServiceTable<Message> MessagesTable = MobileService.GetTable<Message>();
        public static readonly IMobileServiceTable<Channel> ChannelsTable = MobileService.GetTable<Channel>();

        public static MobileServiceUser MobileServicesUser = null;
        public static UserEntity CurrentUser = new UserEntity();
        public static Channel CurrentChannel = new Channel();

        public MyApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    
        public override void OnCreate()
        {
            try
            {
                base.OnCreate();
                // do application specific things here
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}