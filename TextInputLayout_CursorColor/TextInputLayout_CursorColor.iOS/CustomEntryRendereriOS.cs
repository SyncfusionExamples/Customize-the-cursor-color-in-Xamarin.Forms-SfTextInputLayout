using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TextInputLayout_CursorColor;
using TextInputLayout_CursorColor.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRendereriOS))]
namespace TextInputLayout_CursorColor.iOS
{
    public class CustomEntryRendereriOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TintColor = UIColor.Green;
            }
        }
    }
}