using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using thuchanh.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace thuchanh
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Anh> anhs;
        private ObservableCollection<Thongtin> Thongtins;

        public MainPage()
        {
            this.InitializeComponent();

            anhs = new List<Anh>();
            anhs.Add(new Anh { ImagePath = "Assets/1.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/2.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/3.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/4.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/5.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/6.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/7.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/8.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/9.jpg" });
            anhs.Add(new Anh { ImagePath = "Assets/10.jpg" });




            Thongtins = new ObservableCollection<Thongtin>();
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Anh)ImageBox.SelectedValue).ImagePath;
            Thongtins.Add(new Thongtin { Product = ProductBox.Text, Description = DescriptionBox.Text, anh = image });

            ProductBox.Text = "";
            DescriptionBox.Text = "";
            ImageBox.SelectedIndex = -1;

            ProductBox.Focus(FocusState.Programmatic);
        }
    }
}
