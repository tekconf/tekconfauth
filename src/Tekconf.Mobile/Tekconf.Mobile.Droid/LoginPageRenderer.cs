using System;
using Android.App;
using Tekconf.Mobile;
using Tekconf.Mobile.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Auth;
[assembly: ExportRenderer(typeof(LoginPage), typeof(LoginPageRenderer))]

namespace Tekconf.Mobile.Droid
{
    public class LoginPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            // this is a ViewGroup - so should be able to load an AXML file and FindView<>
            var activity = this.Context as Activity;

            var auth = new OAuth2Authenticator(
                clientId: "native", // your OAuth2 client id
                scope: "openid roles", // the scopes for the particular API you're accessing, delimited by "+" symbols
                authorizeUrl: new Uri(TekconfConstants.IdSrvAuthorize), // the auth URL for the service
                redirectUrl: new Uri("")
            ); // the redirect URL for the service

            auth.Completed += (sender, eventArgs) => {
                if (eventArgs.IsAuthenticated)
                {
                    //App.SuccessfulLoginAction.Invoke();
                    // Use eventArgs.Account to do wonderful things
                    //App.SaveToken(eventArgs.Account.Properties["access_token"]);
                }
                else {
                    // The user cancelled
                }
            };

            //activity.StartActivity(auth.GetUI(activity));
        }

    }
}