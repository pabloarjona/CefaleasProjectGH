using Xamarin.Forms;

namespace CefaleasApp.Views.Effects
{
    public static class RoundCornersEffectProperties
    {
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.CreateAttached("CornerRadius", typeof(float), typeof(RoundCornersEffect), 0.0f);

        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.CreateAttached("BorderThickness", typeof(float), typeof(RoundCornersEffect), 0.0f);

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.CreateAttached("BorderColor", typeof(Color), typeof(RoundCornersEffect), Color.Transparent);
    }

}
