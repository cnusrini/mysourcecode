using System;
using EmpTrack.Customization;
using EmpTrack.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginButton), typeof(RoundedBorderedLoginButton))]
namespace EmpTrack.iOS.Renderers
{
    public class RoundedBorderedLoginButton : ButtonRenderer
    {
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			if (Control != null)
			{
				Control.Layer.CornerRadius = 12;
				Control.ClipsToBounds = true;
			}
		}
    }
}
