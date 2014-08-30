using Android.App;
using Android.Content;
using PushSharp.Client;
using Xamarin.MobileServices.Android.Helpers;

namespace com.fundora.mobileservices.demo
{
    [BroadcastReceiver(Permission = GCMConstants.PERMISSION_GCM_INTENTS)]
    [IntentFilter(new[] { GCMConstants.INTENT_FROM_GCM_MESSAGE }, Categories = new[] { Constants.PackageName })]
    [IntentFilter(new[] { GCMConstants.INTENT_FROM_GCM_REGISTRATION_CALLBACK }, Categories = new[] { Constants.PackageName })]
    [IntentFilter(new[] { GCMConstants.INTENT_FROM_GCM_LIBRARY_RETRY }, Categories = new[] { Constants.PackageName })]
    public class PushNotificationReceiver : PushHandlerBroadcastReceiverBase<PushHandlerService>
    {
    }
} 