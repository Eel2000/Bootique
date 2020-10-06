using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bootique.CustomeRenderer;
using Bootique.Droid;
using Java.Interop;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomEntry),typeof(CustomEntryAndroid))]
namespace Bootique.Droid
{
    public class CustomEntryAndroid : EntryRenderer
    {
        public CustomEntryAndroid(Context context) :base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(e.OldElement == null)
            {
                var gradiantDrawable = new GradientDrawable();

                gradiantDrawable.SetCornerRadius(10f);
                gradiantDrawable.SetStroke(1, Android.Graphics.Color.Black);
                gradiantDrawable.SetColor(Android.Graphics.Color.White);

                Control.SetBackground(gradiantDrawable);

                Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight, Control.PaddingBottom);
            }
        }
    }
}