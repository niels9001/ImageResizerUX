using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ImageResizer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Photo> SelectedPhotos { get; set; }
        public ObservableCollection<ImageOption> ImageOptions { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            SelectedPhotos = new ObservableCollection<Photo>
            {
                new Photo() { FileName = "Surface 1.jpg", Dimensions = "720 x 480", OldDimensions = "980 x 780", Size = "401 kb", OldSize = "600 kb", Path = "ms-appx:///Assets/Images/Surface 1.jpg" },
                new Photo() { FileName = "Surface 2.jpg", Dimensions = "720 x 460", OldDimensions = "960 x 740", Size = "421 kb", OldSize = "679 kb", Path = "ms-appx:///Assets/Images/Surface 2.jpg" },
                new Photo() { FileName = "Surface 3.jpg", Dimensions = "720 x 480", OldDimensions = "900 x 740", Size = "367 kb", OldSize = "701 kb", Path = "ms-appx:///Assets/Images/Surface 3.jpg" },
                new Photo() { FileName = "Surface 4.jpg", Dimensions = "720 x 470", OldDimensions = "900 x 700", Size = "370 kb", OldSize = "560 kb", Path = "ms-appx:///Assets/Images/Surface 4.jpg" },
                new Photo() { FileName = "Surface 5.jpg", Dimensions = "719 x 480", OldDimensions = "940 x 780", Size = "360 kb", OldSize = "690 kb", Path = "ms-appx:///Assets/Images/Surface 5.jpg" },
                new Photo() { FileName = "Surface 6.jpg", Dimensions = "717 x 480", OldDimensions = "980 x 770", Size = "420 kb", OldSize = "622 kb", Path = "ms-appx:///Assets/Images/Surface 6.jpg" },
                new Photo() { FileName = "Surface 7.jpg", Dimensions = "720 x 480", OldDimensions = "890 x 770", Size = "390 kb", OldSize = "640 kb", Path = "ms-appx:///Assets/Images/Surface 7.jpg" }
            };

            ImageOptions = new ObservableCollection<ImageOption>();
            ImageOptions.Add(new ImageOption() { Title = "Small", Width = 854, Height = 480, Unit = "inches" });
            ImageOptions.Add(new ImageOption() { Title = "Medium", Width = 1366, Height = 768, Unit = "pixels" });
            ImageOptions.Add(new ImageOption() { Title = "Large", Width = 1920, Height = 1080, Unit = "pixels" });

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ImageOptionsComboBox.SelectionChanged += ImageOptionsComboBox_SelectionChanged;
            StretchBox.SelectionChanged += StretchBox_SelectionChanged;
        }

        private void StretchBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PresetCheckBox.Visibility = Visibility.Visible;
                
        }

        private void ImageOptionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImageOption S = ImageOptionsComboBox.SelectedItem as ImageOption;
            WidthText.Text = S.Width.ToString();
            HeightText.Text = S.Height.ToString();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        //private void RadioButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    WidthBox.IsEnabled = true;
        //    HeightBox.IsEnabled = true;
        //}

        //private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    WidthBox.IsEnabled = false;
        //    HeightBox.IsEnabled = false;
        //}
    }

    public class Photo
    {
        public string FileName { get; set; }
        public string Dimensions { get; set; }
        public string OldDimensions { get; set; }
        public string Size { get; set; }
        public string OldSize { get; set; }
        public string Path { get; set; }
    }

    public class ImageOption
    {
        public string Title { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Unit { get; set; }
    }
}
