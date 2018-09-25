using Android.Content;
using App6.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(NoPaddingRenderer))]
namespace App6.Droid
{
    public class NoPaddingRenderer : ButtonRenderer
    {
        public NoPaddingRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            Control?.SetPadding(0,0,0,0);
        }
    }
}