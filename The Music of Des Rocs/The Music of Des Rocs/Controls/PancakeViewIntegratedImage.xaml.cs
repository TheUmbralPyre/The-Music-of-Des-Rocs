using The_Music_of_Des_Rocs.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace The_Music_of_Des_Rocs.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PancakeViewIntegratedImage : ContentView
    {
        public static BindableProperty IntegratedImageSourceProperty = BindableProperty.Create("IntegratedImageSource", typeof(string), typeof(PancakeViewIntegratedImage)
            , null);

        public static BindableProperty IntegratedLabelTextProperty = BindableProperty.Create("IntegratedLabelText", typeof(string), typeof(PancakeViewIntegratedImage)
            , null);

        public string IntegratedImageSource
        {
            get { return (string)GetValue(IntegratedImageSourceProperty); }
            set { SetValue(IntegratedImageSourceProperty, value); }
        }

        public string IntegratedLabelText
        {
            get { return (string)GetValue(IntegratedLabelTextProperty); }
            set { SetValue(IntegratedLabelTextProperty, value); }
        }

        public PancakeViewIntegratedImage()
        {
            var tap = new TapGestureRecognizer();

            tap.Tapped += async (s, e) =>
            {
                await IntegratedPancake.ColorTo(Color.Transparent, Color.FromHex("#1e1617"),
                    c => IntegratedPancake.BackgroundGradientStops[1].Color = c, 400, Easing.SinInOut);

                await IntegratedPancake.ColorTo(Color.FromHex("#1e1617"), Color.Transparent,
                    c => IntegratedPancake.BackgroundGradientStops[1].Color = c, 300, Easing.SinInOut);

            };

            GestureRecognizers.Add(tap);

            InitializeComponent();

            IntegratedImage.SetBinding(Image.SourceProperty, new Binding("IntegratedImageSource", source: this));
            IntegratedLabel.SetBinding(Label.TextProperty, new Binding("IntegratedLabelText", source: this));
        }
    }
}