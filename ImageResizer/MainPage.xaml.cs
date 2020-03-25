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

        public MainPage()
        {
            this.InitializeComponent();

            SelectedPhotos = new ObservableCollection<Photo>
            {
                new Photo() { FileName = "Surface 1.jpg", Dimensions = "720 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 1.jpg" },
                new Photo() { FileName = "Surface 2.jpg", Dimensions = "720 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 2.jpg" },
                new Photo() { FileName = "Surface 3.jpg", Dimensions = "720 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 3.jpg" },
                new Photo() { FileName = "Surface 4.jpg", Dimensions = "720 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 4.jpg" },
                new Photo() { FileName = "Surface 5.jpg", Dimensions = "719 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 5.jpg" },
                new Photo() { FileName = "Surface 6.jpg", Dimensions = "717 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 6.jpg" },
                new Photo() { FileName = "Surface 7.jpg", Dimensions = "720 x 480", Type = "JPEG File", Path = "ms-appx:///Assets/Images/Surface 7.jpg" }
            };
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            WidthBox.IsEnabled = true;
            HeightBox.IsEnabled = true;
        }

        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            WidthBox.IsEnabled = false;
            HeightBox.IsEnabled = false;
        }
    }

    public class Photo
    {
        public string FileName { get; set; }
        public string Dimensions { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
    }
}
