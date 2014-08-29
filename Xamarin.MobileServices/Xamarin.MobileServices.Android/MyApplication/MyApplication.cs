using System;
using Android.App;
using Android.Runtime;
using Microsoft.WindowsAzure.MobileServices;
using PushSharp.Client;
using Xamarin.MobileServices.Android.Helpers;
using Xamarin.MobileServices.Core;

[assembly: Permission(Name = Constants.PackageName + ".permission.C2D_MESSAGE")]
[assembly: UsesPermission(Name = Constants.PackageName + ".permission.C2D_MESSAGE")]
[assembly: UsesPermission(Name = "com.google.android.c2dm.permission.RECEIVE")]
[assembly: UsesPermission(Name = "android.permission.GET_ACCOUNTS")]
[assembly: UsesPermission(Name = "android.permission.INTERNET")]
[assembly: UsesPermission(Name = "android.permission.WAKE_LOCK")]

namespace com.fundora.mobileservices.demo.MyApplication
{
    [Application(Debuggable = true)]
    public class MyApplication : Application
    {
        public static MobileServiceClient MobileService =
            new MobileServiceClient("https://fundoraxamarin.azure-mobile.net/", "zSuDvMZtXKDOCvFtILIxeCUwBEUchV91");

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
                PushClient.CheckDevice(this);
                PushClient.CheckManifest(this);
                PushClient.Register(this, Constants.ProjectNumber);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}