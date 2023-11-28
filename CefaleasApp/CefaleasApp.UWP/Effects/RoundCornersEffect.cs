using CefaleasApp.Views.Effects;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms.PlatformConfiguration;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(CefaleasApp.UWP.Effects.RoundCornersEffect), nameof(CefaleasApp.UWP.Effects.RoundCornersEffect))]
namespace CefaleasApp.UWP.Effects
{
    public class RoundCornersEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var frameworkElement = Control as Windows.UI.Xaml.Controls.Border ?? Container as Windows.UI.Xaml.Controls.Border;

            if (frameworkElement != null)
            {
                var cornerRadius = (float)Element.GetValue(RoundCornersEffectProperties.CornerRadiusProperty);
                var borderThickness = (float)Element.GetValue(RoundCornersEffectProperties.BorderThicknessProperty);
                var borderColor = (Color)Element.GetValue(RoundCornersEffectProperties.BorderColorProperty);

                frameworkElement.CornerRadius = new Windows.UI.Xaml.CornerRadius(cornerRadius,cornerRadius, cornerRadius, cornerRadius);
                frameworkElement.BorderThickness = new Windows.UI.Xaml.Thickness(borderThickness);
                frameworkElement.BorderBrush = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Color.FromArgb((byte)(borderColor.A * 255), (byte)(borderColor.R * 255), (byte)(borderColor.G * 255), (byte)(borderColor.B * 255)));

            }

        }

        protected override void OnDetached()
        {
            
        }
    }
}
